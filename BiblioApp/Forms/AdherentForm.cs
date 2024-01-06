using System.Data;
using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using BiblioApp.Utils;
using LinqKit;
using Microsoft.VisualBasic.FileIO;

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
                uow.Adherent.Add(adherent);
                uow.Complete();
            }
        }
        private void LoadCsvData(string filePath)
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
        public void LoadData()
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
            txtCurrentPage.Text = $"{pagination.PageIndex}/{TotalPages}";
            using (UnitOfWork uow = new(new BibliothequeDbContext()))
            {
                dgvAdherent.DataSource = uow.Adherent.Find(predicate, "", pagination).Select(a => new
                {
                    IdAdherent = a.IdAdherent,
                    NomAdherent = a.NomAdherent,
                    PrenomAdherent = a.PrenomAdherent,
                    EmailAdherent = a.Email,
                }).ToList();
                txtNbAdh.Text = dgvAdherent.RowCount.ToString();
            }
        }
        private void AdherentForm_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvAdherent.Columns["IdAdherent"].Visible = false;
            dgvAdherent.Columns["NomAdherent"].Width = 300;
            dgvAdherent.Columns["PrenomAdherent"].Width = 300;
            dgvAdherent.Columns["EmailAdherent"].Width = 300;
            SharedData.AddColumnIcon(dgvAdherent, "print", "print");
            SharedData.AddColumnIcon(dgvAdherent, "delete", "delete");
            SharedData.AddColumnIcon(dgvAdherent, "edit", "edit");
            dgvAdherent.RowHeadersVisible = false;
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
    }
}
