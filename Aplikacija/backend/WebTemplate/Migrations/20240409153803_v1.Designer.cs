﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebTemplate.Models;

#nullable disable

namespace WebTemplate.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240409153803_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebTemplate.Models.Lezaljka", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<double>("Cena")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Lezaljke");
                });

            modelBuilder.Entity("WebTemplate.Models.Rezervacije", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DatumZaRezervaciju")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LezaljkaID")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("LezaljkaID");

                    b.HasIndex("UserID");

                    b.ToTable("Rezervacije");
                });

            modelBuilder.Entity("WebTemplate.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Sertifikat")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Slika")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TipUsera")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("ID");

                    b.ToTable("Useri");
                });

            modelBuilder.Entity("WebTemplate.Models.Rezervacije", b =>
                {
                    b.HasOne("WebTemplate.Models.Lezaljka", "Lezaljka")
                        .WithMany("Rezervacije")
                        .HasForeignKey("LezaljkaID");

                    b.HasOne("WebTemplate.Models.User", "User")
                        .WithMany("Rezervacije")
                        .HasForeignKey("UserID");

                    b.Navigation("Lezaljka");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebTemplate.Models.Lezaljka", b =>
                {
                    b.Navigation("Rezervacije");
                });

            modelBuilder.Entity("WebTemplate.Models.User", b =>
                {
                    b.Navigation("Rezervacije");
                });
#pragma warning restore 612, 618
        }
    }
}
