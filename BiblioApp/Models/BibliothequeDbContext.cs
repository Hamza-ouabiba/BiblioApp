﻿using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BiblioApp.Models
{
    public partial class BibliothequeDbContext : DbContext
    {
        public BibliothequeDbContext()
        {
        }

        public BibliothequeDbContext(DbContextOptions<BibliothequeDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adherent> Adherents { get; set; }
        public virtual DbSet<Auteur> Auteurs { get; set; }
        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Employe> Employes { get; set; }
        public virtual DbSet<Livre> Livres { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["bibliothequeDb"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");

            modelBuilder.Entity<Adherent>(entity =>
            {
                entity.HasKey(e => e.IdAdherent)
                    .HasName("PK__Adherent__7FD6B6C3CA5DB3F3");

                entity.ToTable("Adherent");

                entity.Property(e => e.IdAdherent).HasColumnName("idAdherent");

                entity.Property(e => e.DateInscription)
                    .HasColumnType("date")
                    .HasColumnName("dateInscription");

                entity.Property(e => e.NomAdherent)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nomAdherent");

                entity.Property(e => e.PrenomAdherent)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("prenomAdherent");
            });

            modelBuilder.Entity<Auteur>(entity =>
            {
                entity.HasKey(e => e.IdAuteur)
                    .HasName("PK__Auteur__58A6E8B9BCE55829");

                entity.ToTable("Auteur");

                entity.Property(e => e.IdAuteur).HasColumnName("idAuteur");

                entity.Property(e => e.DateNaissance)
                    .HasColumnType("date")
                    .HasColumnName("dateNaissance");

                entity.Property(e => e.Nationalite)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nationalite");

                entity.Property(e => e.NomAuteur)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nomAuteur");

                entity.Property(e => e.PrenomAuteur)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("prenomAuteur");
            });

            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.HasKey(e => e.IdCategorie)
                    .HasName("PK__Categori__8A3D2408320D83F3");

                entity.ToTable("Categorie");

                entity.Property(e => e.IdCategorie).HasColumnName("idCategorie");

                entity.Property(e => e.NomCategorie)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nomCategorie");
            });

            modelBuilder.Entity<Employe>(entity =>
            {
                entity.HasKey(e => e.IdEmploye)
                    .HasName("PK__Employe__97B32F2A5725FB37");

                entity.ToTable("Employe");

                entity.Property(e => e.IdEmploye).HasColumnName("idEmploye");
            });

            modelBuilder.Entity<Livre>(entity =>
            {
                entity.HasKey(e => e.IdLivre)
                    .HasName("PK__Livre__63C546D9EE21A7A4");

                entity.ToTable("Livre");

                entity.Property(e => e.IdLivre).HasColumnName("idLivre");

                entity.Property(e => e.IdAuteur).HasColumnName("idAuteur");

                entity.Property(e => e.IdCategorie).HasColumnName("idCategorie");

                entity.HasOne(d => d.IdAuteurNavigation)
                    .WithMany(p => p.Livres)
                    .HasForeignKey(d => d.IdAuteur)
                    .HasConstraintName("FK_LIVRE_ASSOCIATI_AUTEUR");

                entity.HasOne(d => d.IdCategorieNavigation)
                    .WithMany(p => p.Livres)
                    .HasForeignKey(d => d.IdCategorie)
                    .HasConstraintName("FK_LIVRE_ASSOCIATI_CATEGORI");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasKey(e => new { e.IdLivre, e.IdAdherent })
                    .HasName("PK__Reservat__44382DB50ED7A50C");

                entity.ToTable("Reservation");

                entity.Property(e => e.IdLivre).HasColumnName("idLivre");

                entity.Property(e => e.IdAdherent).HasColumnName("idAdherent");

                entity.Property(e => e.Periode)
                    .HasColumnType("date")
                    .HasColumnName("periode");

                entity.HasOne(d => d.IdAdherentNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.IdAdherent)
                    .HasConstraintName("FK_RESERVAT_ASSOCIATI_ADHERENT");

                entity.HasOne(d => d.IdLivreNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.IdLivre)
                    .HasConstraintName("FK_RESERVAT_ASSOCIATI_LIVRE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
