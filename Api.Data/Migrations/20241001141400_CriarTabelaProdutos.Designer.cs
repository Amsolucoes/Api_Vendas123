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
    [Migration("20241001141400_CriarTabelaProdutos")]
    partial class CriarTabelaProdutos
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
                            Id = new Guid("d28debd0-290f-4fc0-8084-501982a440ad"),
                            CreateAt = new DateTime(2024, 10, 1, 11, 13, 59, 967, DateTimeKind.Local).AddTicks(9399),
                            Email = "mfrinfo@mail.com",
                            Name = "Administrador",
                            UpdateAt = new DateTime(2024, 10, 1, 11, 13, 59, 967, DateTimeKind.Local).AddTicks(9410)
                        });
                });

            modelBuilder.Entity("ComprarEntityProdutoEntity", b =>
                {
                    b.Property<Guid>("ComprasId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ProdutosId")
                        .HasColumnType("char(36)");

                    b.HasKey("ComprasId", "ProdutosId");

                    b.HasIndex("ProdutosId");

                    b.ToTable("ComprarEntityProdutoEntity");
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

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Produtos", (string)null);
                });

            modelBuilder.Entity("ComprarEntityProdutoEntity", b =>
                {
                    b.HasOne("Domain.Entities.ComprarEntity", null)
                        .WithMany()
                        .HasForeignKey("ComprasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.ProdutoEntity", null)
                        .WithMany()
                        .HasForeignKey("ProdutosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
