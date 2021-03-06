﻿// <auto-generated />
using System;
using Aula10ValidaçãoDados2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aula10ValidaçãoDados2.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Aula10ValidaçãoDados2.Models.Usuario", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UsuarioId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnName("Idade")
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasColumnName("CPF")
                        .HasColumnType("ntext");

                    b.Property<DateTime>("Date")
                        .HasColumnName("Nascimento")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .HasColumnName("Nome")
                        .HasColumnType("ntext");

                    b.HasKey("PersonId");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
