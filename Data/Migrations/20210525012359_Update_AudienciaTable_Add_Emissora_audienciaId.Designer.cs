﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(ContextApp))]
    [Migration("20210525012359_Update_AudienciaTable_Add_Emissora_audienciaId")]
    partial class Update_AudienciaTable_Add_Emissora_audienciaId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Audiencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data_hora_audiencia")
                        .HasColumnType("datetime2");

                    b.Property<int>("Emissora_audienciaId")
                        .HasColumnType("int");

                    b.Property<double>("Pontos_audiencia")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Emissora_audienciaId");

                    b.ToTable("Audiencias");
                });

            modelBuilder.Entity("Domain.Entities.Emissora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Emissoras");
                });

            modelBuilder.Entity("Domain.Entities.Audiencia", b =>
                {
                    b.HasOne("Domain.Entities.Emissora", "Emissora_audiencia")
                        .WithMany()
                        .HasForeignKey("Emissora_audienciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Emissora_audiencia");
                });
#pragma warning restore 612, 618
        }
    }
}
