﻿// <auto-generated />
using System;
using BoletoBusMaMonolitica.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BoletoBusMaMonolitica.Migrations
{
    [DbContext(typeof(BoletoBusContext))]
    partial class BoletoBusContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BoletoBusMaMonolitica.Data.Entities.Ruta", b =>
                {
                    b.Property<int>("IdRuta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRuta"), 1L, 1);

                    b.Property<DateTime>("ChangeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ChangeUser")
                        .HasColumnType("int");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Origen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRuta");

                    b.ToTable("Ruta");
                });
#pragma warning restore 612, 618
        }
    }
}
