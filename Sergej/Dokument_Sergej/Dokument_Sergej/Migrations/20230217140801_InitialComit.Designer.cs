﻿// <auto-generated />
using System;
using Dokument_Sergej.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dokument_Sergej.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230217140801_InitialComit")]
    partial class InitialComit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dokument_Sergej.Models.Dokument", b =>
                {
                    b.Property<int>("DokumentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DokumentID"));

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumDonosenjaOdluke")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("LicnostID")
                        .HasColumnType("int");

                    b.Property<string>("Sablon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZavodniBroj")
                        .HasColumnType("int");

                    b.HasKey("DokumentID");

                    b.ToTable("Dokumenti");
                });

            modelBuilder.Entity("Dokument_Sergej.Models.KorisnikSistema", b =>
                {
                    b.Property<int>("KorisnikSistemaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikSistemaID"));

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KorisnikSistemaID");

                    b.ToTable("KorisniciSistema");
                });

            modelBuilder.Entity("Dokument_Sergej.Models.Licnost", b =>
                {
                    b.Property<int>("LicnostID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LicnostID"));

                    b.Property<string>("Funkcija")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LicnostID");

                    b.ToTable("Licnosti");
                });
#pragma warning restore 612, 618
        }
    }
}
