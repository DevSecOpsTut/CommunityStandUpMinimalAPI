﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieDb.Models;

#nullable disable

namespace MovieDb.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20220815081033_AddCastNew")]
    partial class AddCastNew
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("MovieDb.Models.Cast", b =>
                {
                    b.Property<int>("CastId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("MovieId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CastId");

                    b.HasIndex("MovieId");

                    b.ToTable("Casts");
                });

            modelBuilder.Entity("MovieDb.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieDb.Models.Cast", b =>
                {
                    b.HasOne("MovieDb.Models.Movie", null)
                        .WithMany("Cast")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("MovieDb.Models.Movie", b =>
                {
                    b.Navigation("Cast");
                });
#pragma warning restore 612, 618
        }
    }
}
