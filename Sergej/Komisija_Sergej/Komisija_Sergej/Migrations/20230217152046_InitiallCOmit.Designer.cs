﻿// <auto-generated />
using Komisija_Sergej.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Komisija_Sergej.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230217152046_InitiallCOmit")]
    partial class InitiallCOmit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Komisija_Sergej.Models.Komisija", b =>
                {
                    b.Property<int>("KomisijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KomisijaID"));

                    b.Property<string>("Clan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Predsednik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KomisijaID");

                    b.ToTable("Komisije");
                });
#pragma warning restore 612, 618
        }
    }
}