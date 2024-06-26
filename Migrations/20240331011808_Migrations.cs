﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsultorioAPI.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anamnesis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Usuario = table.Column<long>(type: "bigint", nullable: false),
                    Motivo_Consulta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emfermedad_Actual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atencion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anamnesis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ant_Familiar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Usuario = table.Column<long>(type: "bigint", nullable: false),
                    Cancer = table.Column<int>(type: "int", nullable: false),
                    Sinusitis = table.Column<int>(type: "int", nullable: false),
                    Organos_Sentidos = table.Column<int>(type: "int", nullable: false),
                    Diabetes = table.Column<int>(type: "int", nullable: false),
                    Infecciones = table.Column<int>(type: "int", nullable: false),
                    Hepatitis = table.Column<int>(type: "int", nullable: false),
                    Epilepsia = table.Column<int>(type: "int", nullable: false),
                    TransGastricos = table.Column<int>(type: "int", nullable: false),
                    Cardiopatias = table.Column<int>(type: "int", nullable: false),
                    FiebReumatica = table.Column<int>(type: "int", nullable: false),
                    TrataMedico = table.Column<int>(type: "int", nullable: false),
                    Enfermedad_Respiratoria = table.Column<int>(type: "int", nullable: false),
                    Hipertension = table.Column<int>(type: "int", nullable: false),
                    AltCoagulatorias = table.Column<int>(type: "int", nullable: false),
                    Transtorno_Neumologico = table.Column<int>(type: "int", nullable: false),
                    Ten_Arterial = table.Column<int>(type: "int", nullable: false),
                    Otros = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Embarazo = table.Column<int>(type: "int", nullable: false),
                    Meses = table.Column<int>(type: "int", nullable: false),
                    Lactancia = table.Column<int>(type: "int", nullable: false),
                    Frecuencia_Cepillado = table.Column<int>(type: "int", nullable: false),
                    CedaDental = table.Column<int>(type: "int", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atencion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ant_Familiar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "cartaDentalAdulto",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Usuario = table.Column<long>(type: "bigint", nullable: false),
                    c11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c26 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c27 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c31 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c32 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c33 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c34 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c35 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c36 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c37 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c38 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c41 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c42 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c43 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c44 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c45 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c46 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c47 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c48 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atencion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cartaDentalAdulto", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "cartaDentalNino",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Usuario = table.Column<long>(type: "bigint", nullable: false),
                    c51 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c52 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c53 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c54 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c55 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c61 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c62 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c63 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c64 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c65 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c71 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c72 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c73 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c74 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c75 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c81 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c82 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c83 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c84 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c85 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atencion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cartaDentalNino", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Usuario = table.Column<long>(type: "bigint", nullable: false),
                    Fecha_Cita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora_Cita = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ciudad",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Ciudad = table.Column<int>(type: "int", nullable: false),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    ID_Departamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Convecciones",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Conveccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convecciones", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Departamento = table.Column<int>(type: "int", nullable: false),
                    Nombre_Departamento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EstadoCivil",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CivilNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCivil", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EstadoTratamiento",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Usuario = table.Column<long>(type: "bigint", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Diente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tratamiento_Efectuado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doctor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atencion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoTratamiento", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Estomatologico",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Usuario = table.Column<long>(type: "bigint", nullable: false),
                    Labios = table.Column<int>(type: "int", nullable: false),
                    Encias = table.Column<int>(type: "int", nullable: false),
                    Paladar = table.Column<int>(type: "int", nullable: false),
                    Carrillos = table.Column<int>(type: "int", nullable: false),
                    Lengua = table.Column<int>(type: "int", nullable: false),
                    Musculos = table.Column<int>(type: "int", nullable: false),
                    Piso_Boca = table.Column<int>(type: "int", nullable: false),
                    Oro_farige = table.Column<int>(type: "int", nullable: false),
                    Frenillos = table.Column<int>(type: "int", nullable: false),
                    Maxilares = table.Column<int>(type: "int", nullable: false),
                    GlanSalivales = table.Column<int>(type: "int", nullable: false),
                    Atencion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estomatologico", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    ID_Genero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.ID_Genero);
                });

            migrationBuilder.CreateTable(
                name: "Imagenes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Usuario = table.Column<int>(type: "int", nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCarga = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagenes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PlanTratamiento",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Usuario = table.Column<long>(type: "bigint", nullable: false),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pronostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tratamiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atencion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanTratamiento", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumento",
                columns: table => new
                {
                    ID_Documento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumento", x => x.ID_Documento);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Usuario = table.Column<long>(type: "bigint", nullable: false),
                    ID_Documento = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Fecha_Nacido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado_Civil = table.Column<int>(type: "int", nullable: false),
                    Ocupacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aseguradora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_Genero = table.Column<int>(type: "int", nullable: false),
                    ID_Ciudad = table.Column<int>(type: "int", nullable: false),
                    ID_Departamento = table.Column<int>(type: "int", nullable: false),
                    Oficina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre_Acudiente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Referido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atencion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
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
                name: "cartaDentalAdulto");

            migrationBuilder.DropTable(
                name: "cartaDentalNino");

            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Ciudad");

            migrationBuilder.DropTable(
                name: "Convecciones");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "EstadoCivil");

            migrationBuilder.DropTable(
                name: "EstadoTratamiento");

            migrationBuilder.DropTable(
                name: "Estomatologico");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Imagenes");

            migrationBuilder.DropTable(
                name: "PlanTratamiento");

            migrationBuilder.DropTable(
                name: "TipoDocumento");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
