﻿// <auto-generated />
using System;
using LicnostProjekat.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LicnostProjekat.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230218195055_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LicnostProjekat.Models.Adresa", b =>
                {
                    b.Property<int>("AdresaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdresaID"));

                    b.Property<string>("Broj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Drzava")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mesto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostanskiBroj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ulica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdresaID");

                    b.ToTable("Adresas");
                });

            modelBuilder.Entity("LicnostProjekat.Models.FizickoLice", b =>
                {
                    b.Property<int>("FizickoLiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FizickoLiceID"));

                    b.Property<int>("AdresaID")
                        .HasColumnType("int");

                    b.Property<string>("BrojRacuna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KontaktOsobaID")
                        .HasColumnType("int");

                    b.Property<int>("LicnostID")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FizickoLiceID");

                    b.HasIndex("AdresaID");

                    b.HasIndex("KontaktOsobaID");

                    b.HasIndex("LicnostID");

                    b.ToTable("FizickaLicas");
                });

            modelBuilder.Entity("LicnostProjekat.Models.KontaktOsoba", b =>
                {
                    b.Property<int>("KontaktOsobaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KontaktOsobaID"));

                    b.Property<string>("Funkcija")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KontaktOsobaID");

                    b.ToTable("KontaktOsobas");
                });

            modelBuilder.Entity("LicnostProjekat.Models.Kupac", b =>
                {
                    b.Property<int>("KupacID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KupacID"));

                    b.Property<DateTime>("DatumPocetkaZabrane")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPrestankaZabrane")
                        .HasColumnType("datetime2");

                    b.Property<int>("DuzinaTrajanjaZabraneUGodinama")
                        .HasColumnType("int");

                    b.Property<bool>("ImaZabranu")
                        .HasColumnType("bit");

                    b.Property<string>("Lice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OstvarenaPovrsina")
                        .HasColumnType("int");

                    b.Property<string>("Prioritet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uplate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KupacID");

                    b.ToTable("Kupcis");
                });

            modelBuilder.Entity("LicnostProjekat.Models.Licnost", b =>
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

                    b.Property<int>("KupacID")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LicnostID");

                    b.HasIndex("KupacID");

                    b.ToTable("Licnostis");
                });

            modelBuilder.Entity("LicnostProjekat.Models.PravnoLice", b =>
                {
                    b.Property<int>("PravnoLiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PravnoLiceID"));

                    b.Property<int>("AdresaID")
                        .HasColumnType("int");

                    b.Property<string>("BrojRacuna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Faks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KupacID")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PravnoLiceID");

                    b.ToTable("PravnaLicas");
                });

            modelBuilder.Entity("LicnostProjekat.Models.FizickoLice", b =>
                {
                    b.HasOne("LicnostProjekat.Models.Adresa", "adresa")
                        .WithMany()
                        .HasForeignKey("AdresaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LicnostProjekat.Models.KontaktOsoba", "KontaktOsoba")
                        .WithMany()
                        .HasForeignKey("KontaktOsobaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LicnostProjekat.Models.Licnost", "Licnost")
                        .WithMany()
                        .HasForeignKey("LicnostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KontaktOsoba");

                    b.Navigation("Licnost");

                    b.Navigation("adresa");
                });

            modelBuilder.Entity("LicnostProjekat.Models.Licnost", b =>
                {
                    b.HasOne("LicnostProjekat.Models.Kupac", "kupac")
                        .WithMany()
                        .HasForeignKey("KupacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("kupac");
                });
#pragma warning restore 612, 618
        }
    }
}