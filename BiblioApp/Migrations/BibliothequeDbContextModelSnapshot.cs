﻿// <auto-generated />
using System;
using BiblioApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BiblioApp.Migrations
{
    [DbContext(typeof(BibliothequeDbContext))]
    partial class BibliothequeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "French_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BiblioApp.Models.Adherent", b =>
                {
                    b.Property<int>("IdAdherent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idAdherent")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateInscription")
                        .HasColumnType("date")
                        .HasColumnName("dateInscription");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomAdherent")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nomAdherent");

                    b.Property<string>("PrenomAdherent")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("prenomAdherent");

                    b.HasKey("IdAdherent")
                        .HasName("PK__Adherent__7FD6B6C3CA5DB3F3");

                    b.ToTable("Adherent");
                });

            modelBuilder.Entity("BiblioApp.Models.Auteur", b =>
                {
                    b.Property<int>("IdAuteur")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idAuteur")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("Genre")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NomAuteur")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nomAuteur");

                    b.HasKey("IdAuteur")
                        .HasName("PK__Auteur__58A6E8B9BCE55829");

                    b.ToTable("Auteur");
                });

            modelBuilder.Entity("BiblioApp.Models.Categorie", b =>
                {
                    b.Property<int>("IdCategorie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idCategorie")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomCategorie")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nomCategorie");

                    b.HasKey("IdCategorie")
                        .HasName("PK__Categori__8A3D2408320D83F3");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("BiblioApp.Models.Employe", b =>
                {
                    b.Property<int>("IdEmploye")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idEmploye")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsAdmin")
                        .HasColumnType("bit")
                        .HasColumnName("isAdmin");

                    b.Property<string>("Nom")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nom");

                    b.HasKey("IdEmploye")
                        .HasName("PK__Employe__97B32F2A5725FB37");

                    b.ToTable("Employe");
                });

            modelBuilder.Entity("BiblioApp.Models.Etat", b =>
                {
                    b.Property<int>("IdEtat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nom");

                    b.HasKey("IdEtat");

                    b.ToTable("Etats");
                });

            modelBuilder.Entity("BiblioApp.Models.Livre", b =>
                {
                    b.Property<int>("IdLivre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idLivre")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Couverture")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("DatePublication")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdAuteur")
                        .HasColumnType("int")
                        .HasColumnName("idAuteur");

                    b.Property<int>("IdCategorie")
                        .HasColumnType("int")
                        .HasColumnName("idCategorie");

                    b.Property<int?>("IdEtat")
                        .HasColumnType("int");

                    b.Property<int>("NbPages")
                        .HasColumnType("int");

                    b.Property<float>("Prix")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLivre")
                        .HasName("PK__Livre__63C546D9EE21A7A4");

                    b.HasIndex(new[] { "IdEtat" }, "IX_Livre_IdEtatNavigationIdEtat");

                    b.HasIndex(new[] { "IdAuteur" }, "IX_Livre_idAuteur");

                    b.HasIndex(new[] { "IdCategorie" }, "IX_Livre_idCategorie");

                    b.ToTable("Livre");
                });

            modelBuilder.Entity("BiblioApp.Models.Reservation", b =>
                {
                    b.Property<int>("IdLivre")
                        .HasColumnType("int")
                        .HasColumnName("idLivre");

                    b.Property<int>("IdAdherent")
                        .HasColumnType("int")
                        .HasColumnName("idAdherent");

                    b.Property<DateTime?>("Periode")
                        .HasColumnType("date")
                        .HasColumnName("periode");

                    b.HasKey("IdLivre", "IdAdherent")
                        .HasName("PK__Reservat__44382DB50ED7A50C");

                    b.HasIndex(new[] { "IdAdherent" }, "IX_Reservation_idAdherent");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("BiblioApp.Models.Livre", b =>
                {
                    b.HasOne("BiblioApp.Models.Auteur", "Auteur")
                        .WithMany("Livres")
                        .HasForeignKey("IdAuteur")
                        .HasConstraintName("FK_LIVRE_ASSOCIATI_AUTEUR")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BiblioApp.Models.Categorie", "Categorie")
                        .WithMany("Livres")
                        .HasForeignKey("IdCategorie")
                        .HasConstraintName("FK_LIVRE_ASSOCIATI_CATEGORI")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BiblioApp.Models.Etat", "Etat")
                        .WithMany("Livres")
                        .HasForeignKey("IdEtat")
                        .HasConstraintName("FK_Livre_Etats_IdEtatNavigationIdEtat");

                    b.Navigation("Auteur");

                    b.Navigation("Categorie");

                    b.Navigation("Etat");
                });

            modelBuilder.Entity("BiblioApp.Models.Reservation", b =>
                {
                    b.HasOne("BiblioApp.Models.Adherent", "Adherent")
                        .WithMany("Reservations")
                        .HasForeignKey("IdAdherent")
                        .HasConstraintName("FK_RESERVAT_ASSOCIATI_ADHERENT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BiblioApp.Models.Livre", "Livre")
                        .WithMany("Reservations")
                        .HasForeignKey("IdLivre")
                        .HasConstraintName("FK_RESERVAT_ASSOCIATI_LIVRE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adherent");

                    b.Navigation("Livre");
                });

            modelBuilder.Entity("BiblioApp.Models.Adherent", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("BiblioApp.Models.Auteur", b =>
                {
                    b.Navigation("Livres");
                });

            modelBuilder.Entity("BiblioApp.Models.Categorie", b =>
                {
                    b.Navigation("Livres");
                });

            modelBuilder.Entity("BiblioApp.Models.Etat", b =>
                {
                    b.Navigation("Livres");
                });

            modelBuilder.Entity("BiblioApp.Models.Livre", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
