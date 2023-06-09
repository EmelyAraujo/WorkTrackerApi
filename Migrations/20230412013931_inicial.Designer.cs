﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkTrackerApi.Data;

#nullable disable

namespace WorkTrackerApi.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230412013931_inicial")]
    partial class inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("WorkTrackerApi.Models.Materiales", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantFaltante")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantRetirada")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double?>("PrecioUd")
                        .HasColumnType("REAL");

                    b.Property<string>("Suplidor")
                        .HasColumnType("TEXT");

                    b.Property<int>("obraId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MaterialId");

                    b.ToTable("materiales");
                });

            modelBuilder.Entity("WorkTrackerApi.Models.Obras", b =>
                {
                    b.Property<int>("ObraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DuenoObra")
                        .HasColumnType("TEXT");

                    b.HasKey("ObraId");

                    b.ToTable("obras");
                });
#pragma warning restore 612, 618
        }
    }
}
