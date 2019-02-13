﻿// <auto-generated />
using DotNetGram.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetGram.Migrations
{
    [DbContext(typeof(PostDbContext))]
    partial class PostDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Poster");

                    b.HasKey("ID");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Placeholder One",
                            Image = "https://via.placeholder.com/150",
                            Poster = "Clari"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Placeholder Two",
                            Image = "https://via.placeholder.com/150",
                            Poster = "Nate"
                        },
                        new
                        {
                            ID = 3,
                            Description = "Placeholder Three",
                            Image = "https://via.placeholder.com/150",
                            Poster = "Mike"
                        },
                        new
                        {
                            ID = 4,
                            Description = "Placeholder Four",
                            Image = "https://via.placeholder.com/150",
                            Poster = "Xia"
                        },
                        new
                        {
                            ID = 5,
                            Description = "Placeholder Five",
                            Image = "https://via.placeholder.com/150",
                            Poster = "Mike G."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}