﻿// <auto-generated />
using System;
using CinemaEf;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CinemaEf.Migrations
{
    [DbContext(typeof(CinemaContext))]
    [Migration("20180914082757_NewStart")]
    partial class NewStart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CinemaEf.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LocationId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Cinema");
                });

            modelBuilder.Entity("CinemaEf.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mail");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CinemaEf.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("CinemaEf.Klasser.MovieGenre", b =>
                {
                    b.Property<int>("MovieId");

                    b.Property<int>("GenreId");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("MovieGenres");
                });

            modelBuilder.Entity("CinemaEf.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("CinemaEf.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgeLevel");

                    b.Property<string>("Description");

                    b.Property<string>("Genre");

                    b.Property<string>("Language");

                    b.Property<int?>("MovieTypeId");

                    b.Property<string>("Name");

                    b.Property<string>("Subtitles");

                    b.HasKey("Id");

                    b.HasIndex("MovieTypeId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("CinemaEf.MovieType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("MovieType");
                });

            modelBuilder.Entity("CinemaEf.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId");

                    b.Property<string>("DeliveryMethod");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("CinemaEf.Salon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Has3D");

                    b.Property<bool>("HasImax");

                    b.Property<bool>("HasVIP");

                    b.Property<bool>("IsChildFriendly");

                    b.Property<string>("Name");

                    b.Property<int>("SeatingAmount");

                    b.HasKey("Id");

                    b.ToTable("Salon");
                });

            modelBuilder.Entity("CinemaEf.SalonInCinema", b =>
                {
                    b.Property<int>("CinemaId");

                    b.Property<int>("SalonId");

                    b.HasKey("CinemaId", "SalonId");

                    b.HasIndex("SalonId");

                    b.ToTable("SalonInCinema");
                });

            modelBuilder.Entity("CinemaEf.Shows", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MovieId");

                    b.Property<int>("SalonId");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("SalonId");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("CinemaEf.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OrderId");

                    b.Property<int?>("ShowsId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ShowsId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("CinemaEf.Cinema", b =>
                {
                    b.HasOne("CinemaEf.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("CinemaEf.Klasser.MovieGenre", b =>
                {
                    b.HasOne("CinemaEf.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinemaEf.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CinemaEf.Movie", b =>
                {
                    b.HasOne("CinemaEf.MovieType", "MovieType")
                        .WithMany()
                        .HasForeignKey("MovieTypeId");
                });

            modelBuilder.Entity("CinemaEf.Order", b =>
                {
                    b.HasOne("CinemaEf.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("CinemaEf.SalonInCinema", b =>
                {
                    b.HasOne("CinemaEf.Cinema", "Cinema")
                        .WithMany()
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinemaEf.Salon", "Salon")
                        .WithMany()
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CinemaEf.Shows", b =>
                {
                    b.HasOne("CinemaEf.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinemaEf.Salon", "Salon")
                        .WithMany()
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CinemaEf.Ticket", b =>
                {
                    b.HasOne("CinemaEf.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("CinemaEf.Shows", "Shows")
                        .WithMany()
                        .HasForeignKey("ShowsId");
                });
#pragma warning restore 612, 618
        }
    }
}
