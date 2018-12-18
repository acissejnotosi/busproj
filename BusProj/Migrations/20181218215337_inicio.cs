using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusCore.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deteccao",
                columns: table => new
                {
                    DetecaoTipoId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ProbabilidadeDeteccao = table.Column<string>(nullable: true),
                    FaixasCriteriosDeteccao = table.Column<string>(nullable: true),
                    IndiceDeteccao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deteccao", x => x.DetecaoTipoId);
                });

            migrationBuilder.CreateTable(
                name: "Ocorrencia",
                columns: table => new
                {
                    OcorrenciaId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Probabilidade = table.Column<string>(nullable: true),
                    TaxasFalhasPossiveis = table.Column<string>(nullable: true),
                    IndiceOcorrencia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocorrencia", x => x.OcorrenciaId);
                });

            migrationBuilder.CreateTable(
                name: "Severidade",
                columns: table => new
                {
                    SeveridadeId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    SeveridadeTipo = table.Column<string>(nullable: true),
                    EfeitoDaSeveridade = table.Column<string>(nullable: true),
                    IndiceSeveridade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Severidade", x => x.SeveridadeId);
                });

            migrationBuilder.CreateTable(
                name: "TipoDescricao",
                columns: table => new
                {
                    TipoDescricaoID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDescricao", x => x.TipoDescricaoID);
                });

            migrationBuilder.CreateTable(
                name: "TipoOnibus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Descricao = table.Column<string>(nullable: true),
                    Peso = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoOnibus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Linha",
                columns: table => new
                {
                    LinhaID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    NumeroLinha = table.Column<int>(nullable: false),
                    NomeLinha = table.Column<string>(nullable: true),
                    TotalRPNFreiosFabrica = table.Column<double>(nullable: false),
                    TotalRPNEmbreagemFabrica = table.Column<double>(nullable: false),
                    TotalRPNSuspensaoFabrica = table.Column<double>(nullable: false),
                    TotalKmFreiosFabrica = table.Column<double>(nullable: false),
                    TotalKmEmbreagemFabrica = table.Column<double>(nullable: false),
                    TotalKmSuspensaoFabrica = table.Column<double>(nullable: false),
                    RPNSuspensaoBuracoFabrica = table.Column<double>(nullable: false),
                    RPNSuspensaoRedutorFabrica = table.Column<double>(nullable: false),
                    RPNSuspensaoCargaFabrica = table.Column<double>(nullable: false),
                    RPNEmbreagemParadaFabrica = table.Column<double>(nullable: false),
                    RPNEmbreagemSemaforoFabrica = table.Column<double>(nullable: false),
                    RPNEmbreagemRedutorFabrica = table.Column<double>(nullable: false),
                    RPNFreioParadaFabrica = table.Column<double>(nullable: false),
                    RPNFreioSemaforoFabrica = table.Column<double>(nullable: false),
                    RPNFreioRedutorFabrica = table.Column<double>(nullable: false),
                    TipoOnibusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linha", x => x.LinhaID);
                    table.ForeignKey(
                        name: "FK_Linha_TipoOnibus_TipoOnibusId",
                        column: x => x.TipoOnibusId,
                        principalTable: "TipoOnibus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Embreagem",
                columns: table => new
                {
                    EmbreagemID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    OcorrenciaID = table.Column<int>(nullable: true),
                    SeveridadeID = table.Column<int>(nullable: true),
                    DeteccaoID = table.Column<int>(nullable: true),
                    TipoDescricaoID = table.Column<int>(nullable: true),
                    RPNEmbreagemCalculado = table.Column<int>(nullable: false),
                    RPNParadaCalculado = table.Column<int>(nullable: false),
                    RPNSemaforoCalculado = table.Column<int>(nullable: false),
                    RPNRedutoresCalculado = table.Column<int>(nullable: false),
                    LinhaID = table.Column<int>(nullable: true),
                    DataHora = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Embreagem", x => x.EmbreagemID);
                    table.ForeignKey(
                        name: "FK_Embreagem_Deteccao_DeteccaoID",
                        column: x => x.DeteccaoID,
                        principalTable: "Deteccao",
                        principalColumn: "DetecaoTipoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Embreagem_Linha_LinhaID",
                        column: x => x.LinhaID,
                        principalTable: "Linha",
                        principalColumn: "LinhaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Embreagem_Ocorrencia_OcorrenciaID",
                        column: x => x.OcorrenciaID,
                        principalTable: "Ocorrencia",
                        principalColumn: "OcorrenciaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Embreagem_Severidade_SeveridadeID",
                        column: x => x.SeveridadeID,
                        principalTable: "Severidade",
                        principalColumn: "SeveridadeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Embreagem_TipoDescricao_TipoDescricaoID",
                        column: x => x.TipoDescricaoID,
                        principalTable: "TipoDescricao",
                        principalColumn: "TipoDescricaoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Freio",
                columns: table => new
                {
                    FreioID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    OcorrenciaID = table.Column<int>(nullable: true),
                    SeveridadeID = table.Column<int>(nullable: true),
                    DeteccaoID = table.Column<int>(nullable: true),
                    TipoDescricaoID = table.Column<int>(nullable: true),
                    RPNFreioCalculado = table.Column<int>(nullable: false),
                    RPNPontosParadaCalculado = table.Column<int>(nullable: false),
                    RPNSemaforoCalculado = table.Column<int>(nullable: false),
                    RPNRedutoresCalculado = table.Column<int>(nullable: false),
                    LinhaID = table.Column<int>(nullable: true),
                    DataHora = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freio", x => x.FreioID);
                    table.ForeignKey(
                        name: "FK_Freio_Deteccao_DeteccaoID",
                        column: x => x.DeteccaoID,
                        principalTable: "Deteccao",
                        principalColumn: "DetecaoTipoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Freio_Linha_LinhaID",
                        column: x => x.LinhaID,
                        principalTable: "Linha",
                        principalColumn: "LinhaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Freio_Ocorrencia_OcorrenciaID",
                        column: x => x.OcorrenciaID,
                        principalTable: "Ocorrencia",
                        principalColumn: "OcorrenciaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Freio_Severidade_SeveridadeID",
                        column: x => x.SeveridadeID,
                        principalTable: "Severidade",
                        principalColumn: "SeveridadeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Freio_TipoDescricao_TipoDescricaoID",
                        column: x => x.TipoDescricaoID,
                        principalTable: "TipoDescricao",
                        principalColumn: "TipoDescricaoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoLinha",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Data = table.Column<DateTime>(nullable: false),
                    NumBuracos = table.Column<int>(nullable: false),
                    NumLombadas = table.Column<int>(nullable: false),
                    NumSemaforos = table.Column<int>(nullable: false),
                    NumParadas = table.Column<int>(nullable: false),
                    LinhaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoLinha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoLinha_Linha_LinhaID",
                        column: x => x.LinhaID,
                        principalTable: "Linha",
                        principalColumn: "LinhaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suspensao",
                columns: table => new
                {
                    SuspensaoID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    OcorrenciaID = table.Column<int>(nullable: true),
                    SeveridadeID = table.Column<int>(nullable: true),
                    DeteccaoID = table.Column<int>(nullable: true),
                    TipoDescricaoID = table.Column<int>(nullable: true),
                    RPNSuspensaoCalculado = table.Column<int>(nullable: false),
                    RPNBuracoCalculado = table.Column<int>(nullable: false),
                    RPNRedutorCalculado = table.Column<int>(nullable: false),
                    RPNCargaCalculado = table.Column<int>(nullable: false),
                    LinhaID = table.Column<int>(nullable: true),
                    DataHora = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suspensao", x => x.SuspensaoID);
                    table.ForeignKey(
                        name: "FK_Suspensao_Deteccao_DeteccaoID",
                        column: x => x.DeteccaoID,
                        principalTable: "Deteccao",
                        principalColumn: "DetecaoTipoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Suspensao_Linha_LinhaID",
                        column: x => x.LinhaID,
                        principalTable: "Linha",
                        principalColumn: "LinhaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Suspensao_Ocorrencia_OcorrenciaID",
                        column: x => x.OcorrenciaID,
                        principalTable: "Ocorrencia",
                        principalColumn: "OcorrenciaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Suspensao_Severidade_SeveridadeID",
                        column: x => x.SeveridadeID,
                        principalTable: "Severidade",
                        principalColumn: "SeveridadeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Suspensao_TipoDescricao_TipoDescricaoID",
                        column: x => x.TipoDescricaoID,
                        principalTable: "TipoDescricao",
                        principalColumn: "TipoDescricaoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Embreagem_DeteccaoID",
                table: "Embreagem",
                column: "DeteccaoID");

            migrationBuilder.CreateIndex(
                name: "IX_Embreagem_LinhaID",
                table: "Embreagem",
                column: "LinhaID");

            migrationBuilder.CreateIndex(
                name: "IX_Embreagem_OcorrenciaID",
                table: "Embreagem",
                column: "OcorrenciaID");

            migrationBuilder.CreateIndex(
                name: "IX_Embreagem_SeveridadeID",
                table: "Embreagem",
                column: "SeveridadeID");

            migrationBuilder.CreateIndex(
                name: "IX_Embreagem_TipoDescricaoID",
                table: "Embreagem",
                column: "TipoDescricaoID");

            migrationBuilder.CreateIndex(
                name: "IX_Freio_DeteccaoID",
                table: "Freio",
                column: "DeteccaoID");

            migrationBuilder.CreateIndex(
                name: "IX_Freio_LinhaID",
                table: "Freio",
                column: "LinhaID");

            migrationBuilder.CreateIndex(
                name: "IX_Freio_OcorrenciaID",
                table: "Freio",
                column: "OcorrenciaID");

            migrationBuilder.CreateIndex(
                name: "IX_Freio_SeveridadeID",
                table: "Freio",
                column: "SeveridadeID");

            migrationBuilder.CreateIndex(
                name: "IX_Freio_TipoDescricaoID",
                table: "Freio",
                column: "TipoDescricaoID");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoLinha_LinhaID",
                table: "HistoricoLinha",
                column: "LinhaID");

            migrationBuilder.CreateIndex(
                name: "IX_Linha_TipoOnibusId",
                table: "Linha",
                column: "TipoOnibusId");

            migrationBuilder.CreateIndex(
                name: "IX_Suspensao_DeteccaoID",
                table: "Suspensao",
                column: "DeteccaoID");

            migrationBuilder.CreateIndex(
                name: "IX_Suspensao_LinhaID",
                table: "Suspensao",
                column: "LinhaID");

            migrationBuilder.CreateIndex(
                name: "IX_Suspensao_OcorrenciaID",
                table: "Suspensao",
                column: "OcorrenciaID");

            migrationBuilder.CreateIndex(
                name: "IX_Suspensao_SeveridadeID",
                table: "Suspensao",
                column: "SeveridadeID");

            migrationBuilder.CreateIndex(
                name: "IX_Suspensao_TipoDescricaoID",
                table: "Suspensao",
                column: "TipoDescricaoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Embreagem");

            migrationBuilder.DropTable(
                name: "Freio");

            migrationBuilder.DropTable(
                name: "HistoricoLinha");

            migrationBuilder.DropTable(
                name: "Suspensao");

            migrationBuilder.DropTable(
                name: "Deteccao");

            migrationBuilder.DropTable(
                name: "Linha");

            migrationBuilder.DropTable(
                name: "Ocorrencia");

            migrationBuilder.DropTable(
                name: "Severidade");

            migrationBuilder.DropTable(
                name: "TipoDescricao");

            migrationBuilder.DropTable(
                name: "TipoOnibus");
        }
    }
}
