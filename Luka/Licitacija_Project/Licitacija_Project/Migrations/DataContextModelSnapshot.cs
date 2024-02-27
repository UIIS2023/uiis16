﻿// <auto-generated />
using System;
using Licitacija_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Licitacija_Project.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Licitacija_Project.Models.DokumentVO", b =>
                {
                    b.Property<int>("DokumentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DokumentID"));

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumDonosenjaDokumenta")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sablon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZavodniBroj")
                        .HasColumnType("int");

                    b.HasKey("DokumentID");

                    b.ToTable("DokumentVOs");
                });

            modelBuilder.Entity("Licitacija_Project.Models.JavnoNadmetanjeVO", b =>
                {
                    b.Property<int>("JavnoNadmetanjeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JavnoNadmetanjeID"));

                    b.Property<int>("BrojUcesnika")
                        .HasColumnType("int");

                    b.Property<int>("IzlicitiranaCena")
                        .HasColumnType("int");

                    b.Property<bool>("Izuzeto")
                        .HasColumnType("bit");

                    b.Property<int>("PeriodZakupa")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisinaDopuneDepozita")
                        .HasColumnType("int");

                    b.Property<string>("VremeKraja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JavnoNadmetanjeID");

                    b.ToTable("JavnoNadmetanjeVOs");
                });

            modelBuilder.Entity("Licitacija_Project.Models.Licitacija", b =>
                {
                    b.Property<int>("LicitacijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LicitacijaID"));

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("DokumentID")
                        .HasColumnType("int");

                    b.Property<int>("Godina")
                        .HasColumnType("int");

                    b.Property<int>("JavnoNadmetanjeID")
                        .HasColumnType("int");

                    b.Property<int>("KorakCene")
                        .HasColumnType("int");

                    b.Property<string>("ListaDokumentacijeFizickaLica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ListaDokumentacijePravnaLica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ogranicenje")
                        .HasColumnType("int");

                    b.Property<string>("RokZaDostavljanjePrijava")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dokumentVODokumentID")
                        .HasColumnType("int");

                    b.Property<int>("javnoNadmetanjeVOJavnoNadmetanjeID")
                        .HasColumnType("int");

                    b.HasKey("LicitacijaID");

                    b.HasIndex("dokumentVODokumentID");

                    b.HasIndex("javnoNadmetanjeVOJavnoNadmetanjeID");

                    b.ToTable("Licitacijas");
                });

            modelBuilder.Entity("Licitacija_Project.Models.Licitacija", b =>
                {
                    b.HasOne("Licitacija_Project.Models.DokumentVO", "dokumentVO")
                        .WithMany()
                        .HasForeignKey("dokumentVODokumentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Licitacija_Project.Models.JavnoNadmetanjeVO", "javnoNadmetanjeVO")
                        .WithMany()
                        .HasForeignKey("javnoNadmetanjeVOJavnoNadmetanjeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dokumentVO");

                    b.Navigation("javnoNadmetanjeVO");
                });
#pragma warning restore 612, 618
        }
    }
}
