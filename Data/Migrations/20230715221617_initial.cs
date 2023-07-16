using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsultorioAPI.data.migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anamnesis",
                columns: table => new
                {
                    Id_Usuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Motivo_Consulta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emf_Actual = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anamnesis", x => x.Id_Usuario);
                });

            migrationBuilder.CreateTable(
                name: "Ant_Familiar",
                columns: table => new
                {
                    Id_Usuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Cancer = table.Column<int>(type: "int", nullable: false),
                    Sinusitis = table.Column<int>(type: "int", nullable: false),
                    Organos_Sentidos = table.Column<int>(type: "int", nullable: false),
                    Diabetes = table.Column<int>(type: "int", nullable: false),
                    Infecciones = table.Column<int>(type: "int", nullable: false),
                    Hepatitis = table.Column<int>(type: "int", nullable: false),
                    Trans_Gastricos = table.Column<int>(type: "int", nullable: false),
                    Cardiopatias = table.Column<int>(type: "int", nullable: false),
                    Fieb_Reumatica = table.Column<int>(type: "int", nullable: false),
                    Trata_Medico = table.Column<int>(type: "int", nullable: false),
                    Enf_Respiratoria = table.Column<int>(type: "int", nullable: false),
                    Hipertension = table.Column<int>(type: "int", nullable: false),
                    Alt_Coagulatorias = table.Column<int>(type: "int", nullable: false),
                    Trans_Neumologico = table.Column<int>(type: "int", nullable: false),
                    Ten_Arterial = table.Column<int>(type: "int", nullable: false),
                    Otros = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Embarazo = table.Column<int>(type: "int", nullable: false),
                    Meses = table.Column<int>(type: "int", nullable: false),
                    Lactancia = table.Column<int>(type: "int", nullable: false),
                    Fre_Cepillado = table.Column<int>(type: "int", nullable: false),
                    Ceda_Dental = table.Column<int>(type: "int", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ant_Familiar", x => x.Id_Usuario);
                });

            migrationBuilder.CreateTable(
                name: "Ciudad",
                columns: table => new
                {
                    Id_Ciudad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Id_Departamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.Id_Ciudad);
                });

            migrationBuilder.CreateTable(
                name: "Convecciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Conveccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convecciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    Id_Departamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDepartamento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.Id_Departamento);
                });

            migrationBuilder.CreateTable(
                name: "EstadoCivil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CivilNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCivil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estomatologico",
                columns: table => new
                {
                    Id_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Labios = table.Column<int>(type: "int", nullable: false),
                    Encias = table.Column<int>(type: "int", nullable: false),
                    Paladar = table.Column<int>(type: "int", nullable: false),
                    Carrillos = table.Column<int>(type: "int", nullable: false),
                    Lengua = table.Column<int>(type: "int", nullable: false),
                    Musculos = table.Column<int>(type: "int", nullable: false),
                    Piso_Boca = table.Column<int>(type: "int", nullable: false),
                    Orofarige = table.Column<int>(type: "int", nullable: false),
                    Frenillos = table.Column<int>(type: "int", nullable: false),
                    Maxilares = table.Column<int>(type: "int", nullable: false),
                    Glan_Salivales = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id_Genero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id_Genero);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumento",
                columns: table => new
                {
                    Id_Documento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumento", x => x.Id_Documento);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id_Usuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id_Documento = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Fecha_Nacido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado_Civil = table.Column<int>(type: "int", nullable: false),
                    Ocupacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aseguradora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Genero = table.Column<int>(type: "int", nullable: false),
                    Id_Ciudad = table.Column<int>(type: "int", nullable: false),
                    Id_Departamento = table.Column<int>(type: "int", nullable: false),
                    Oficina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre_Acudiente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Referido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atencion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id_Usuario);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anamnesis");

            migrationBuilder.DropTable(
                name: "Ant_Familiar");

            migrationBuilder.DropTable(
                name: "Ciudad");

            migrationBuilder.DropTable(
                name: "Convecciones");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "EstadoCivil");

            migrationBuilder.DropTable(
                name: "Estomatologico");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "TipoDocumento");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
