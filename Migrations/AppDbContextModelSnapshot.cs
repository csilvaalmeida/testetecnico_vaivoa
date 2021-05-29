﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using creditcardapi.Models;

namespace dotnet.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("creditcardapi.Models.Cartao", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("clienteId")
                        .HasColumnType("int");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("clienteId");

                    b.ToTable("Cartao");
                });

            modelBuilder.Entity("creditcardapi.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("creditcardapi.Models.Cartao", b =>
                {
                    b.HasOne("creditcardapi.Models.Cliente", "cliente")
                        .WithMany("cartoes")
                        .HasForeignKey("clienteId");

                    b.Navigation("cliente");
                });

            modelBuilder.Entity("creditcardapi.Models.Cliente", b =>
                {
                    b.Navigation("cartoes");
                });
#pragma warning restore 612, 618
        }
    }
}