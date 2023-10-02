﻿// <auto-generated />
using System;
using ConsultorioAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsultorioAPI.Migrations
{
    [DbContext(typeof(consultorioDBContext))]
    partial class consultorioDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConsultorioAPI.Model.CartaDentalAdulto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Atencion")
                        .HasColumnType("datetime2");

                    b.Property<long>("Id_Usuario")
                        .HasColumnType("bigint");

                    b.Property<string>("c11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c16")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c17")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c18")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c21")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c22")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c23")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c24")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c25")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c26")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c27")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c28")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c31")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c32")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c33")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c34")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c35")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c36")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c37")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c38")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c41")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c42")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c43")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c44")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c45")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c46")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c47")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c48")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("cartaDentalAdulto");
                });

            modelBuilder.Entity("ConsultorioAPI.Model.CartaDentalNino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Atencion")
                        .HasColumnType("datetime2");

                    b.Property<long>("Id_Usuario")
                        .HasColumnType("bigint");

                    b.Property<string>("c51")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c52")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c53")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c54")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c55")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c61")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c62")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c63")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c65")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c71")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c72")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c73")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c74")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c75")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c81")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c82")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c83")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c84")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c85")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("cartaDentalNino");
                });

            modelBuilder.Entity("ConsultorioAPI.Model.Citas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaCita")
                        .HasColumnType("datetime2");

                    b.Property<string>("HoraCita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Id_Usuario")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("ConsultorioAPI.Model.Convecciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Conveccion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Convecciones");
                });

            modelBuilder.Entity("ConsultorioAPI.Model.EstadoCivil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CivilNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EstadoCivil");
                });

            modelBuilder.Entity("ConsultorioAPI.Model.EstadoTratamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Atencion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Id_Usuario")
                        .HasColumnType("bigint");

                    b.Property<string>("Trata_Efectuado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EstadoTratamiento");
                });

            modelBuilder.Entity("ConsultorioAPI.Model.Imagenes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Fecha_Carga")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Imagenes");
                });

            modelBuilder.Entity("ConsultorioAPI.Model.PlanTratamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Atencion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Id_Usuario")
                        .HasColumnType("bigint");

                    b.Property<string>("Pronostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tratamiento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PlanTratamiento");
                });

            modelBuilder.Entity("OdontologiaWeb.Models.Anamnesis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Atencion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Emf_Actual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Id_Usuario")
                        .HasColumnType("bigint");

                    b.Property<string>("Motivo_Consulta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Anamnesis");
                });

            modelBuilder.Entity("OdontologiaWeb.Models.Ant_Familiar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Alt_Coagulatorias")
                        .HasColumnType("int");

                    b.Property<DateTime>("Atencion")
                        .HasColumnType("datetime2");

                    b.Property<int>("Cancer")
                        .HasColumnType("int");

                    b.Property<int>("Cardiopatias")
                        .HasColumnType("int");

                    b.Property<int>("Ceda_Dental")
                        .HasColumnType("int");

                    b.Property<int>("Diabetes")
                        .HasColumnType("int");

                    b.Property<int>("Embarazo")
                        .HasColumnType("int");

                    b.Property<int>("Enf_Respiratoria")
                        .HasColumnType("int");

                    b.Property<int>("Fieb_Reumatica")
                        .HasColumnType("int");

                    b.Property<int>("Fre_Cepillado")
                        .HasColumnType("int");

                    b.Property<int>("Hepatitis")
                        .HasColumnType("int");

                    b.Property<int>("Hipertension")
                        .HasColumnType("int");

                    b.Property<long>("Id_Usuario")
                        .HasColumnType("bigint");

                    b.Property<int>("Infecciones")
                        .HasColumnType("int");

                    b.Property<int>("Lactancia")
                        .HasColumnType("int");

                    b.Property<int>("Meses")
                        .HasColumnType("int");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Organos_Sentidos")
                        .HasColumnType("int");

                    b.Property<string>("Otros")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sinusitis")
                        .HasColumnType("int");

                    b.Property<int>("Ten_Arterial")
                        .HasColumnType("int");

                    b.Property<int>("Trans_Gastricos")
                        .HasColumnType("int");

                    b.Property<int>("Trans_Neumologico")
                        .HasColumnType("int");

                    b.Property<int>("Trata_Medico")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ant_Familiar");
                });

            modelBuilder.Entity("OdontologiaWeb.Models.Ciudad", b =>
                {
                    b.Property<int>("Id_Ciudad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Ciudad"));

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int>("Id_Departamento")
                        .HasColumnType("int");

                    b.Property<string>("Municipio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Ciudad");

                    b.ToTable("Ciudad");
                });

            modelBuilder.Entity("OdontologiaWeb.Models.Departamento", b =>
                {
                    b.Property<int>("Id_Departamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Departamento"));

                    b.Property<string>("NombreDepartamento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Departamento");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("OdontologiaWeb.Models.Estomatologico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Atencion")
                        .HasColumnType("datetime2");

                    b.Property<int>("Carrillos")
                        .HasColumnType("int");

                    b.Property<int>("Encias")
                        .HasColumnType("int");

                    b.Property<int>("Frenillos")
                        .HasColumnType("int");

                    b.Property<int>("Glan_Salivales")
                        .HasColumnType("int");

                    b.Property<long>("Id_Usuario")
                        .HasColumnType("bigint");

                    b.Property<int>("Labios")
                        .HasColumnType("int");

                    b.Property<int>("Lengua")
                        .HasColumnType("int");

                    b.Property<int>("Maxilares")
                        .HasColumnType("int");

                    b.Property<int>("Musculos")
                        .HasColumnType("int");

                    b.Property<int>("Orofarige")
                        .HasColumnType("int");

                    b.Property<int>("Paladar")
                        .HasColumnType("int");

                    b.Property<int>("Piso_Boca")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Estomatologico");
                });

            modelBuilder.Entity("OdontologiaWeb.Models.Genero", b =>
                {
                    b.Property<int>("Id_Genero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Genero"));

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Genero");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("OdontologiaWeb.Models.TipoDocumento", b =>
                {
                    b.Property<int>("Id_Documento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Documento"));

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Documento");

                    b.ToTable("TipoDocumento");
                });

            modelBuilder.Entity("OdontologiaWeb.Models.Usuario", b =>
                {
                    b.Property<long>("Id_Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id_Usuario"));

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Aseguradora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Atencion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("Estado_Civil")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha_Nacido")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Ciudad")
                        .HasColumnType("int");

                    b.Property<int>("Id_Departamento")
                        .HasColumnType("int");

                    b.Property<int>("Id_Documento")
                        .HasColumnType("int");

                    b.Property<int>("Id_Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Acudiente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ocupacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oficina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Referido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Usuario");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
