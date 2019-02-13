﻿// <auto-generated />
using DotNetGram.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetGram.Migrations
{
    [DbContext(typeof(PostDbContext))]
    [Migration("20190213195544_title_change")]
    partial class title_change
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotNetGram.Models.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.HasKey("ID");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Author = "Clari",
                            Description = "Placeholder One",
                            Image = "https://via.placeholder.com/150"
                        },
                        new
                        {
                            ID = 2,
                            Author = "Nate",
                            Description = "Placeholder Two",
                            Image = "https://via.placeholder.com/150"
                        },
                        new
                        {
                            ID = 3,
                            Author = "Mike",
                            Description = "Placeholder Three",
                            Image = "https://via.placeholder.com/150"
                        },
                        new
                        {
                            ID = 4,
                            Author = "Xia",
                            Description = "Placeholder Four",
                            Image = "https://via.placeholder.com/150"
                        },
                        new
                        {
                            ID = 5,
                            Author = "Mike G.",
                            Description = "Placeholder Five",
                            Image = "https://via.placeholder.com/150"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}