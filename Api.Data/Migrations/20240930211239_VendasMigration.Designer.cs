﻿// <auto-generated />
using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240930211239_VendasMigration")]
    partial class VendasMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Api.Domain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("dc680c81-2817-4e9b-b97a-a9d928046176"),
                            CreateAt = new DateTime(2024, 9, 30, 17, 12, 39, 505, DateTimeKind.Local).AddTicks(8404),
                            Email = "mfrinfo@mail.com",
                            Name = "Administrador",
                            UpdateAt = new DateTime(2024, 9, 30, 17, 12, 39, 505, DateTimeKind.Local).AddTicks(8422)
                        });
                });

            modelBuilder.Entity("Domain.Entities.ComprarEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Cliente")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataVenda")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Filial")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("ValorTotalVendas")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Vendas", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ProdutoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Cancelado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Desconto")
                        .HasColumnType("decimal(65,30)");

                    b.Property<Guid?>("Id_Produtos")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("Id_Vendas")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Vendas");

                    b.ToTable("Produtos", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ProdutoEntity", b =>
                {
                    b.HasOne("Domain.Entities.ComprarEntity", "Vendas")
                        .WithMany("Produtos")
                        .HasForeignKey("Id_Vendas")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("Fk_Id_Vendas_Produtos");

                    b.Navigation("Vendas");
                });

            modelBuilder.Entity("Domain.Entities.ComprarEntity", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
