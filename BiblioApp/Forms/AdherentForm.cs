using System.Data;
using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using BiblioApp.Utils;
using LinqKit;
using Microsoft.VisualBasic.FileIO;
using OfficeOpenXml;

namespace BiblioApp.Forms
{
    public partial class AdherentForm : UserControl
    {
        private int TotalPages;
        private Pagination pagination;
        public AdherentForm()
        {
            InitializeComponent();
            this.pagination = new Pagination()
            {
                PageIndex = 1,
                PageSize = 7
            };
        }
        private void PageLastModifier()
        {
            if (dgvAdherent.Rows.Count == 1 && pagination.PageIndex > 1)
            {
                pagination.PageIndex--;
            }
        }
        private void btnCharger_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (filePath.EndsWith(".csv"))
                {
                    LoadCsvData(filePath);
                }
                else if (filePath.EndsWith(".xlsx"))
                {
                    LoadExcelData(filePath);
                }
            }
        }
        private int CalculatePages()
        {
            using (UnitOfWork uow = new(new BibliothequeDbContext()))
            {
                return (int)Math.Ceiling((double)uow.Adherent.GetAll().Count() / pagination.PageSize);
            }
        }
        private void AddToDb(Adherent adherent)
        {
            using (UnitOfWork uow = (new(new BibliothequeDbContext())))
            {
                if (!uow.Adherent.isExistAdherentByEmail(adherent.Email))
                {
                    adherent.Password = "123456";
                    uow.Adherent.Add(adherent);
                    uow.Complete();
                }
            }
        }
        private void LoadExcelData(string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                DataTable dataTable = new DataTable();

                for (int col = 1; col <= worksheet.Dimension.Columns; col++)
                {
                    dataTable.Columns.Add(worksheet.Cells[1, col].Text);
                }

                for (int row = 2; row <= worksheet.Dimension.Rows; row++)
                {
                    List<string> rowData = new List<string>();
                    for (int col = 1; col <= worksheet.Dimension.Columns; col++)
                    {
                        rowData.Add(worksheet.Cells[row, col].Text);
                    }

                    if (DateTime.TryParse(rowData[2], out DateTime result))
                    {
                        DateTime? nullableDateTime = result;
                        Console.WriteLine(nullableDateTime);
                    }

                    Adherent adherent = new Adherent
                    {
                        NomAdherent = rowData[0],
                        PrenomAdherent = rowData[1],
                        DateInscription = result,
                        Email = rowData[3],
                    };
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["NomAdherent"] = adherent.NomAdherent;
                    dataRow["PrenomAdherent"] = adherent.PrenomAdherent;
                    dataRow["DateInscription"] = adherent.DateInscription;
                    dataRow["Email"] = adherent.Email;
                    dataRow["Genre"] = adherent.Genre;
                    dataTable.Rows.Add(dataRow);
                }

                dgvAdherent.DataSource = dataTable;
            }
        }

        private void ExportDataExcel()
        {
            try
            {
                if (dgvAdherent.Rows.Count > 0)
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                        worksheet.Cells[1, 1].Value = "IdAdherent";
                        worksheet.Cells[1, 2].Value = "PrenomAdherent";
                        worksheet.Cells[1, 3].Value = "NomAdherent";
                        worksheet.Cells[1, 4].Value = "DateInscription";
                        worksheet.Cells[1, 5].Value = "Email";

                        using (UnitOfWork uow = new(new BibliothequeDbContext()))
                        {
                            int rows = 2;
                            foreach (Adherent adherent in uow.Adherent.GetAll())
                            {
                                worksheet.Cells[rows, 1].Value = adherent.IdAdherent;
                                worksheet.Cells[rows, 2].Value = adherent.PrenomAdherent;
                                worksheet.Cells[rows, 3].Value = adherent.NomAdherent;
                                worksheet.Cells[rows, 4].Value = adherent.DateInscription;
                                worksheet.Cells[rows, 5].Value = adherent.Email;

                                rows++;
                            }
                        }
                        string uniqueIdentifier = Guid.NewGuid().ToString();
                        SaveFileDialog saveFileDialog = new SaveFileDialog
                        {
                            Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                            Title = "Save Excel File",
                            FileName = $"AdherentData_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}_{uniqueIdentifier}.xlsx"
                        };

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string cheminFichier = saveFileDialog.FileName;
                            package.SaveAs(new FileInfo(cheminFichier));
                            SharedData.MessageUser($"Data exported successfully to the following path: {cheminFichier}");
                        }
                        else
                        {
                            SharedData.MessageUser("Export canceled by the user");
                        }
                    }
                }
                else
                {
                    SharedData.MessageUser("Unable to export without data");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void LoadCsvData(string filePath)
        {
            try
            {
                using (TextFieldParser parser = new TextFieldParser(filePath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    DataTable dataTable = new DataTable();

                    // Assume the first row contains column headers
                    string[] fields = parser.ReadFields();

                    foreach (string field in fields)
                    {
                        dataTable.Columns.Add(field);
                    }

                    while (!parser.EndOfData)
                    {
                        string[] rowData = parser.ReadFields();
                        dataTable.Rows.Add(rowData);
                        if (DateTime.TryParse(rowData[2], out DateTime result))
                        {
                            DateTime? nullableDateTime = result;
                            Console.WriteLine(nullableDateTime);
                        }
                        Adherent adherent = new Adherent
                        {
                            NomAdherent = rowData[0],
                            PrenomAdherent = rowData[1],
                            DateInscription = result,
                            Email = rowData[3],
                        };
                        AddToDb(adherent);
                    }

                    dgvAdherent.DataSource = dataTable;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public void LoadData()
        {
            try
            {
                var predicate = PredicateBuilder.New<Adherent>(true);
                if (!string.IsNullOrEmpty(txtAdherentCriteria.Text))
                {
                    if (txtAdherentCriteria.Text != "")
                    {
                        predicate = predicate.And(e => e.NomAdherent.Contains(txtAdherentCriteria.Text));
                    }
                }

                TotalPages = CalculatePages();

                if (TotalPages > 0)
                {
                    txtCurrentPage.Text = $"{pagination.PageIndex}/{TotalPages}";
                }
                using (UnitOfWork uow = new(new BibliothequeDbContext()))
                {
                    dgvAdherent.DataSource = uow.Adherent.Find(predicate, "", pagination).Select(a => new
                    {
                        IdAdherent = a.IdAdherent,
                        NomAdherent = a.NomAdherent,
                        PrenomAdherent = a.PrenomAdherent,
                        EmailAdherent = a.Email,
                        Gender = a.Genre
                    }).ToList();
                    txtNbAdh.Text = uow.Adherent.GetAll().Count().ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void AdherentForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                dgvAdherent.Columns["IdAdherent"].Visible = false;
                dgvAdherent.Columns["NomAdherent"].Width = 300;
                dgvAdherent.Columns["PrenomAdherent"].Width = 300;
                dgvAdherent.Columns["EmailAdherent"].Width = 300;
                dgvAdherent.Columns["Gender"].Width = 300;
                SharedData.AddColumnIcon(dgvAdherent, "delete", "delete");
                SharedData.AddColumnIcon(dgvAdherent, "edit", "edit");
                dgvAdherent.RowHeadersVisible = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pagination.PageIndex < TotalPages)
            {
                pagination.PageIndex++;
                LoadData();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pagination.PageIndex > 1)
            {
                pagination.PageIndex--;
                LoadData();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pagination.PageIndex = TotalPages;
            LoadData();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pagination.PageIndex = 1;
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportDataExcel();
        }

        private void dgvAdherent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != -1)
                {
                    string colName = dgvAdherent.Columns[e.ColumnIndex].Name;
                    int idAdherent = int.Parse(dgvAdherent.Rows[e.RowIndex].Cells["IdAdherent"].Value.ToString());
                    if (colName == "delete")
                    {
                        bool confirm = SharedData.ConfirmDelete("Voulez vous vraiment supprimer cet adherent  ?");
                        if (confirm)
                        {
                            using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
                            {
                                Adherent adherent = uow.Adherent.Get(idAdherent);
                                uow.Adherent.Remove(adherent);
                                uow.Complete();
                                LoadData();
                                PageLastModifier();
                                txtNbAdh.Text = dgvAdherent.RowCount.ToString();
                                MessageBox.Show($"Adherent {adherent.NomAdherent} supprimée !");
                            }
                        }

                    }
                    else if (colName == "edit")
                    {
                        AddNewAdherent addNewAdherent = new AddNewAdherent(this, idAdherent);
                        addNewAdherent.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewAdh_Click(object sender, EventArgs e)
        {
            AddNewAdherent addNewAdherent = new AddNewAdherent(this, -1);
            addNewAdherent.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvAdherent_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                string colName = dgvAdherent.Columns[e.ColumnIndex].Name;
                if (colName != "delete" && colName != "print" && colName != "edit")
                {
                    dgvAdherent.Cursor = Cursors.Default;
                }
                else
                {
                    dgvAdherent.Cursor = Cursors.Hand;
                }
            }
        }
    }
}
