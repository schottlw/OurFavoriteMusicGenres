﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OurFavoriteMusicGenres.Models;

#nullable disable

namespace OurFavoriteMusicGenres.Migrations
{
    [DbContext(typeof(SongContext))]
    partial class SongContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OurFavoriteMusicGenres.Models.Genre", b =>
                {
                    b.Property<string>("GenreId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = "IF",
                            Name = "Indie Folk"
                        },
                        new
                        {
                            GenreId = "IR",
                            Name = "Indie Rock"
                        },
                        new
                        {
                            GenreId = "P",
                            Name = "Pop"
                        },
                        new
                        {
                            GenreId = "R",
                            Name = "Rap"
                        },
                        new
                        {
                            GenreId = "HH",
                            Name = "Hip Hop"
                        });
                });

            modelBuilder.Entity("OurFavoriteMusicGenres.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SongId"), 1L, 1);

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenreId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SongId");

                    b.HasIndex("GenreId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            SongId = 1,
                            Artist = "Taylor Swift",
                            GenreId = "P",
                            Title = "Karma"
                        },
                        new
                        {
                            SongId = 2,
                            Artist = "BLACKPINK",
                            GenreId = "P",
                            Title = "Pink Venom"
                        });
                });

            modelBuilder.Entity("OurFavoriteMusicGenres.Models.Song", b =>
                {
                    b.HasOne("OurFavoriteMusicGenres.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}
