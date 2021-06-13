﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NadaMVC.Data;

namespace NadaMVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            BookId = 1,
                            Author = "Roald Dahl",
                            Published = 1982,
                            Title = "The BFG",
                            image = "https://upload.wikimedia.org/wikipedia/ar/thumb/b/b2/The_BFG_%28Dahl_novel_-_cover_art%29.jpg/227px-The_BFG_%28Dahl_novel_-_cover_art%29.jpg"
                        },
                        new
                        {
                            BookId = 2,
                            Author = "Jeff Kinney",
                            Published = 2007,
                            Title = "Diary of a Wimpy Kid",
                            image = "https://upload.wikimedia.org/wikipedia/ar/0/09/Diary_of_a_wimpy_kid.jpg"
                        },
                        new
                        {
                            BookId = 3,
                            Author = "Antoine De Saint",
                            Published = 2016,
                            Title = "The Little Prince",
                            image = "https://images-na.ssl-images-amazon.com/images/I/4186P0mACWL._SX336_BO1,204,203,200_.jpg"
                        },
                        new
                        {
                            BookId = 4,
                            Author = "Markus Zusak",
                            Published = 2016,
                            Title = "The Book Thief",
                            image = "https://images-na.ssl-images-amazon.com/images/I/41LxDicrz2L._SX334_BO1,204,203,200_.jpg"
                        },
                        new
                        {
                            BookId = 5,
                            Author = "Gareth Moore",
                            Published = 2014,
                            Title = "Brain Games for Clever Kids",
                            image = "https://images-na.ssl-images-amazon.com/images/I/51WAKxhIoyL._SX328_BO1,204,203,200_.jpg"
                        },
                        new
                        {
                            BookId = 7,
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