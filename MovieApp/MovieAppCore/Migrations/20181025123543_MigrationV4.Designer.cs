﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieAppCore.Models;

namespace MovieAppCore.Migrations
{
    [DbContext(typeof(MoviesDbContext))]
    [Migration("20181025123543_MigrationV4")]
    partial class MigrationV4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieAppCore.Models.Actors", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birth");

                    b.Property<string>("FirstName");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("LastName");

                    b.HasKey("ActorId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("MovieAppCore.Models.Directors", b =>
                {
                    b.Property<int>("DirectorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birth");

                    b.Property<string>("FirstName");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("LastName");

                    b.HasKey("DirectorId");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("MovieAppCore.Models.Genres", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Genre");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("MovieAppCore.Models.MovieActors", b =>
                {
                    b.Property<int>("MovieId");

                    b.Property<int>("ActorId");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId")
                        .IsUnique();

                    b.ToTable("MovieActor");
                });

            modelBuilder.Entity("MovieAppCore.Models.MovieGenres", b =>
                {
                    b.Property<int>("MovieId");

                    b.Property<int>("GenreId");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.HasIndex("MovieId")
                        .IsUnique();

                    b.ToTable("MovieGenre");
                });

            modelBuilder.Entity("MovieAppCore.Models.Movies", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ActorId");

                    b.Property<string>("Description");

                    b.Property<int?>("DirectorId");

                    b.Property<int?>("GenreId");

                    b.Property<string>("ImageUrl");

                    b.Property<DateTimeOffset>("ReleaseDate");

                    b.Property<TimeSpan>("RunTime");

                    b.Property<string>("Title");

                    b.HasKey("MovieId");

                    b.HasIndex("DirectorId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieAppCore.Models.MovieActors", b =>
                {
                    b.HasOne("MovieAppCore.Models.Actors", "Actors")
                        .WithMany("MovieActor")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MovieAppCore.Models.Movies", "Movies")
                        .WithOne("MovieActor")
                        .HasForeignKey("MovieAppCore.Models.MovieActors", "MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MovieAppCore.Models.MovieGenres", b =>
                {
                    b.HasOne("MovieAppCore.Models.Genres", "Genres")
                        .WithMany("MovieGenre")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MovieAppCore.Models.Movies", "Movies")
                        .WithOne("MovieGenre")
                        .HasForeignKey("MovieAppCore.Models.MovieGenres", "MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MovieAppCore.Models.Movies", b =>
                {
                    b.HasOne("MovieAppCore.Models.Directors", "Directors")
                        .WithMany("Movies")
                        .HasForeignKey("DirectorId");
                });
#pragma warning restore 612, 618
        }
    }
}
