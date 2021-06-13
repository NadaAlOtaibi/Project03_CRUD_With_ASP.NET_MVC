﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NadaMVC.Data;

namespace NadaMVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210613052124_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NadaMVC.Models.BookModel", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Published")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("image")
                        .HasColumnType("text");

                    b.HasKey("BookId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            BookId = 6,
                            Author = "Simon",
                            Published = 2021,
                            Title = "Programming",
                            image = "https://images-na.ssl-images-amazon.com/images/I/71d-G-ihrTL.jpg"
                        });
                });

            modelBuilder.Entity("NadaMVC.Models.BooksSellerModel", b =>
                {
                    b.Property<int>("SellerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("image")
                        .HasColumnType("text");

                    b.HasKey("SellerId");

                    b.ToTable("BookSeller");
                });
#pragma warning restore 612, 618
        }
    }
}