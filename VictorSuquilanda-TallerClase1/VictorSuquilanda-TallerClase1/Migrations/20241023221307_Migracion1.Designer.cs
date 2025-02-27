﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VictorSuquilanda_TallerClase1.Data;

#nullable disable

namespace VictorSuquilanda_TallerClase1.Migrations
{
    [DbContext(typeof(VictorSuquilanda_TallerClase1Context))]
    [Migration("20241023221307_Migracion1")]
    partial class Migracion1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VictorSuquilanda_TallerClase1.Models.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AceptaExtranjeros")
                        .HasColumnType("bit");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdEstadio")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Titulos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdEstadio");

                    b.ToTable("Equipo");
                });

            modelBuilder.Entity("VictorSuquilanda_TallerClase1.Models.Estadio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Estadio");
                });

            modelBuilder.Entity("VictorSuquilanda_TallerClase1.Models.Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("IdEquipo")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Posicion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdEquipo");

                    b.ToTable("Jugador");
                });

            modelBuilder.Entity("VictorSuquilanda_TallerClase1.Models.Equipo", b =>
                {
                    b.HasOne("VictorSuquilanda_TallerClase1.Models.Estadio", "Estadio")
                        .WithMany()
                        .HasForeignKey("IdEstadio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estadio");
                });

            modelBuilder.Entity("VictorSuquilanda_TallerClase1.Models.Jugador", b =>
                {
                    b.HasOne("VictorSuquilanda_TallerClase1.Models.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("IdEquipo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");
                });
#pragma warning restore 612, 618
        }
    }
}
