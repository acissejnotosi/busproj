﻿// <auto-generated />
using System;
using BusProj.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusCore.Migrations
{
    [DbContext(typeof(BusCoreContext))]
    partial class BusCoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BusCore.Repository.Entities.Model.RelatorioBuracos", b =>
                {
                    b.Property<int>("RelBuracoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHora");

                    b.Property<int?>("LinhaID");

                    b.Property<int>("NumBuracos");

                    b.HasKey("RelBuracoID");

                    b.HasIndex("LinhaID");

                    b.ToTable("RelatorioBuraco");
                });

            modelBuilder.Entity("BusCore.Repository.Entities.Model.RelatorioLombadas", b =>
                {
                    b.Property<int>("RelLombadaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHora");

                    b.Property<int?>("LinhaID");

                    b.Property<int>("NumLombadas");

                    b.HasKey("RelLombadaID");

                    b.HasIndex("LinhaID");

                    b.ToTable("RelatorioLombada");
                });

            modelBuilder.Entity("BusCore.Repository.Entities.Model.RelatorioParadas", b =>
                {
                    b.Property<int>("RelParadaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHora");

                    b.Property<int?>("LinhaID");

                    b.Property<int>("NumParadas");

                    b.HasKey("RelParadaID");

                    b.HasIndex("LinhaID");

                    b.ToTable("RelatorioParada");
                });

            modelBuilder.Entity("BusCore.Repository.Entities.Model.RelatorioSemaforos", b =>
                {
                    b.Property<int>("RelSemaforoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHora");

                    b.Property<int?>("LinhaID");

                    b.Property<int>("NumSemaforos");

                    b.HasKey("RelSemaforoID");

                    b.HasIndex("LinhaID");

                    b.ToTable("RelatorioSemaforo");
                });

            modelBuilder.Entity("BusCore.Repository.Entities.Model.TipoOnibus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<double>("Peso");

                    b.HasKey("Id");

                    b.ToTable("TipoOnibus");
                });

            modelBuilder.Entity("BusProj.Repository.Entities.Model.Deteccao", b =>
                {
                    b.Property<int>("DetecaoTipoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FaixasCriteriosDeteccao");

                    b.Property<int>("IndiceDeteccao");

                    b.Property<string>("ProbabilidadeDeteccao");

                    b.HasKey("DetecaoTipoId");

                    b.ToTable("Deteccao");
                });

            modelBuilder.Entity("BusProj.Repository.Entities.Model.Embreagem", b =>
                {
                    b.Property<int>("EmbreagemID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHora");

                    b.Property<int?>("DeteccaoID");

                    b.Property<int?>("LinhaID");

                    b.Property<int?>("OcorrenciaID");

                    b.Property<int>("RPNEmbreagemCalculado");

                    b.Property<int?>("SeveridadeID");

                    b.Property<int?>("TipoDescricaoID");

                    b.HasKey("EmbreagemID");

                    b.HasIndex("DeteccaoID");

                    b.HasIndex("LinhaID");

                    b.HasIndex("OcorrenciaID");

                    b.HasIndex("SeveridadeID");

                    b.HasIndex("TipoDescricaoID");

                    b.ToTable("Embreagem");
                });

            modelBuilder.Entity("BusProj.Repository.Entities.Model.Freio", b =>
                {
                    b.Property<int>("FreioID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHora");

                    b.Property<int?>("DeteccaoID");

                    b.Property<int?>("LinhaID");

                    b.Property<int?>("OcorrenciaID");

                    b.Property<int>("RPNFreioCalculado");

                    b.Property<int?>("SeveridadeID");

                    b.Property<int?>("TipoDescricaoID");

                    b.HasKey("FreioID");

                    b.HasIndex("DeteccaoID");

                    b.HasIndex("LinhaID");

                    b.HasIndex("OcorrenciaID");

                    b.HasIndex("SeveridadeID");

                    b.HasIndex("TipoDescricaoID");

                    b.ToTable("Freio");
                });

            modelBuilder.Entity("BusProj.Repository.Entities.Model.Linha", b =>
                {
                    b.Property<int>("LinhaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeLinha");

                    b.Property<int>("NumBuracos");

                    b.Property<int>("NumLombadas");

                    b.Property<int>("NumParadas");

                    b.Property<int>("NumSemaforo");

                    b.Property<int>("NumeroLinha");

                    b.Property<int>("TipoOnibusId");

                    b.Property<double>("TotalKmEmbreagemFabrica");

                    b.Property<double>("TotalKmFreiosFabrica");

                    b.Property<double>("TotalKmSuspensaoFabrica");

                    b.Property<double>("TotalRPNEmbreagemFabrica");

                    b.Property<double>("TotalRPNFreiosFabrica");

                    b.Property<double>("TotalRPNSuspensaoFabrica");

                    b.HasKey("LinhaID");

                    b.HasIndex("TipoOnibusId");

                    b.ToTable("Linha");
                });

            modelBuilder.Entity("BusProj.Repository.Entities.Model.Ocorrencia", b =>
                {
                    b.Property<int>("OcorrenciaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IndiceOcorrencia");

                    b.Property<string>("Probabilidade");

                    b.Property<string>("TaxasFalhasPossiveis");

                    b.HasKey("OcorrenciaId");

                    b.ToTable("Ocorrencia");
                });

            modelBuilder.Entity("BusProj.Repository.Entities.Model.Severidade", b =>
                {
                    b.Property<int>("SeveridadeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EfeitoDaSeveridade");

                    b.Property<int>("IndiceSeveridade");

                    b.Property<string>("SeveridadeTipo");

                    b.HasKey("SeveridadeId");

                    b.ToTable("Severidade");
                });

            modelBuilder.Entity("BusProj.Repository.Entities.Model.Suspensao", b =>
                {
                    b.Property<int>("SuspensaoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHora");

                    b.Property<int?>("DeteccaoID");

                    b.Property<int?>("LinhaID");

                    b.Property<int?>("OcorrenciaID");

                    b.Property<int>("RPNSuspensaoCalculado");

                    b.Property<int?>("SeveridadeID");

                    b.Property<int?>("TipoDescricaoID");

                    b.HasKey("SuspensaoID");

                    b.HasIndex("DeteccaoID");

                    b.HasIndex("LinhaID");

                    b.HasIndex("OcorrenciaID");

                    b.HasIndex("SeveridadeID");

                    b.HasIndex("TipoDescricaoID");

                    b.ToTable("Suspensao");
                });

            modelBuilder.Entity("BusProj.Repository.Entities.Model.TipoDescricao", b =>
                {
                    b.Property<int>("TipoDescricaoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.HasKey("TipoDescricaoID");

                    b.ToTable("TipoDescricao");
                });

            modelBuilder.Entity("BusCore.Repository.Entities.Model.RelatorioBuracos", b =>
                {
                    b.HasOne("BusProj.Repository.Entities.Model.Linha", "LinhaIDCE")
                        .WithMany()
                        .HasForeignKey("LinhaID");
                });

            modelBuilder.Entity("BusCore.Repository.Entities.Model.RelatorioLombadas", b =>
                {
                    b.HasOne("BusProj.Repository.Entities.Model.Linha", "LinhaIDCE")
                        .WithMany()
                        .HasForeignKey("LinhaID");
                });

            modelBuilder.Entity("BusCore.Repository.Entities.Model.RelatorioParadas", b =>
                {
                    b.HasOne("BusProj.Repository.Entities.Model.Linha", "LinhaIDCE")
                        .WithMany()
                        .HasForeignKey("LinhaID");
                });

            modelBuilder.Entity("BusCore.Repository.Entities.Model.RelatorioSemaforos", b =>
                {
                    b.HasOne("BusProj.Repository.Entities.Model.Linha", "LinhaIDCE")
                        .WithMany()
                        .HasForeignKey("LinhaID");
                });

            modelBuilder.Entity("BusProj.Repository.Entities.Model.Embreagem", b =>
                {
                    b.HasOne("BusProj.Repository.Entities.Model.Deteccao", "Deteccao")
                        .WithMany()
                        .HasForeignKey("DeteccaoID");

                    b.HasOne("BusProj.Repository.Entities.Model.Linha", "LinhaIDCE")
                        .WithMany()
                        .HasForeignKey("LinhaID");

                    b.HasOne("BusProj.Repository.Entities.Model.Ocorrencia", "Ocorrencia")
                        .WithMany()
                        .HasForeignKey("OcorrenciaID");

                    b.HasOne("BusProj.Repository.Entities.Model.Severidade", "Severidade")
                        .WithMany()
                        .HasForeignKey("SeveridadeID");

                    b.HasOne("BusProj.Repository.Entities.Model.TipoDescricao", "DescricaoTipo")
                        .WithMany()
                        .HasForeignKey("TipoDescricaoID");
                });

            modelBuilder.Entity("BusProj.Repository.Entities.Model.Freio", b =>
                {
                    b.HasOne("BusProj.Repository.Entities.Model.Deteccao", "Deteccao")
                        .WithMany()
                        .HasForeignKey("DeteccaoID");

                    b.HasOne("BusProj.Repository.Entities.Model.Linha", "LinhaIDCE")
                        .WithMany()
                        .HasForeignKey("LinhaID");

                    b.HasOne("BusProj.Repository.Entities.Model.Ocorrencia", "Ocorrencia")
                        .WithMany()
                        .HasForeignKey("OcorrenciaID");

                    b.HasOne("BusProj.Repository.Entities.Model.Severidade", "Severidade")
                        .WithMany()
                        .HasForeignKey("SeveridadeID");

                    b.HasOne("BusProj.Repository.Entities.Model.TipoDescricao", "DescricaoTipo")
                        .WithMany()
                        .HasForeignKey("TipoDescricaoID");
                });

            modelBuilder.Entity("BusProj.Repository.Entities.Model.Linha", b =>
                {
                    b.HasOne("BusCore.Repository.Entities.Model.TipoOnibus", "TipoOnibus")
                        .WithMany()
                        .HasForeignKey("TipoOnibusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BusProj.Repository.Entities.Model.Suspensao", b =>
                {
                    b.HasOne("BusProj.Repository.Entities.Model.Deteccao", "Deteccao")
                        .WithMany()
                        .HasForeignKey("DeteccaoID");

                    b.HasOne("BusProj.Repository.Entities.Model.Linha", "LinhaIDCE")
                        .WithMany()
                        .HasForeignKey("LinhaID");

                    b.HasOne("BusProj.Repository.Entities.Model.Ocorrencia", "Ocorrencia")
                        .WithMany()
                        .HasForeignKey("OcorrenciaID");

                    b.HasOne("BusProj.Repository.Entities.Model.Severidade", "Severidade")
                        .WithMany()
                        .HasForeignKey("SeveridadeID");

                    b.HasOne("BusProj.Repository.Entities.Model.TipoDescricao", "DescricaoTipo")
                        .WithMany()
                        .HasForeignKey("TipoDescricaoID");
                });
#pragma warning restore 612, 618
        }
    }
}
