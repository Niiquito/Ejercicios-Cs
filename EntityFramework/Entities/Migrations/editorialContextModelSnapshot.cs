﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entities.Migrations
{
    [DbContext(typeof(editorialContext))]
    partial class editorialContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Cargos", b =>
                {
                    b.Property<int>("cargoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cargoID"), 1L, 1);

                    b.Property<string>("cargoDescripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("nivelMaximo")
                        .HasColumnType("smallint");

                    b.Property<short>("nivelMinimo")
                        .HasColumnType("smallint");

                    b.HasKey("cargoID");

                    b.ToTable("Cargo", (string)null);
                });

            modelBuilder.Entity("Entities.Editorial", b =>
                {
                    b.Property<int>("editorialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("editorialID"), 1L, 1);

                    b.Property<string>("ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("editorialNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("editorialID");

                    b.ToTable("Editorial", (string)null);
                });

            modelBuilder.Entity("Entities.titulos", b =>
                {
                    b.Property<int>("tituloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("tituloId"), 1L, 1);

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("adelanto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("editorialID")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("notas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("regalias")
                        .HasColumnType("int");

                    b.Property<string>("tituloName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ventaAnual")
                        .HasColumnType("int");

                    b.HasKey("tituloId");

                    b.HasIndex("editorialID");

                    b.ToTable("titulo", (string)null);
                });

            modelBuilder.Entity("Entities.titulos", b =>
                {
                    b.HasOne("Entities.Editorial", "editorial")
                        .WithMany()
                        .HasForeignKey("editorialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("editorial");
                });
#pragma warning restore 612, 618
        }
    }
}
