﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPILibros.Data;

namespace WebAPILibros.Migrations
{
    [DbContext(typeof(DBLibrosContext))]
    [Migration("20230124171720_correccionFK")]
    partial class correccionFK
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPILibros.Models.Autor", b =>
                {
                    b.Property<int>("IdAutor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdAutor");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("WebAPILibros.Models.Libro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.ToTable("Libro");
                });

            modelBuilder.Entity("WebAPILibros.Models.Libro", b =>
                {
                    b.HasOne("WebAPILibros.Models.Autor", "Autor")
                        .WithMany("Libros")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
