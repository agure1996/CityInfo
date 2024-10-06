﻿// <auto-generated />
using CityInfo.API.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CityInfo.API.Migrations
{
    [DbContext(typeof(CityInfoContext))]
    [Migration("20241006035115_InitialDataSeedComplete")]
    partial class InitialDataSeedComplete
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("CityInfo.API.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "City with big park",
                            Name = "New York City"
                        },
                        new
                        {
                            Id = 2,
                            Description = "City with Liidho Beach",
                            Name = "Xamar City"
                        },
                        new
                        {
                            Id = 3,
                            Description = "City with Eiffel tower",
                            Name = "Paris"
                        },
                        new
                        {
                            Id = 4,
                            Description = "North city",
                            Name = "Hargeisa"
                        });
                });

            modelBuilder.Entity("CityInfo.API.Entities.PointOfInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("PointOfInterests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Description = "Food Joint",
                            Name = "Hazzerdous"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Description = "Game Park",
                            Name = "Jumanji"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 1,
                            Description = "A prayer mosque",
                            Name = "Mosque of NY"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 2,
                            Description = "Beach resort",
                            Name = "Xeebta Liido"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 2,
                            Description = "A prayer mosque",
                            Name = "Masaajidka Xamar"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 3,
                            Description = "Dessert parlor",
                            Name = "Benzema browns"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 3,
                            Description = "Footie Spot",
                            Name = "Iniesta"
                        },
                        new
                        {
                            Id = 8,
                            CityId = 3,
                            Description = "A prayer mosque",
                            Name = "Mosque of Paris"
                        },
                        new
                        {
                            Id = 9,
                            CityId = 4,
                            Description = "Social area for elders",
                            Name = "Haraar House"
                        },
                        new
                        {
                            Id = 10,
                            CityId = 4,
                            Description = "A prayer mosque",
                            Name = "Masaajidka Hargeisa"
                        });
                });

            modelBuilder.Entity("CityInfo.API.Entities.PointOfInterest", b =>
                {
                    b.HasOne("CityInfo.API.Entities.City", "City")
                        .WithMany("PointsOfInterest")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("CityInfo.API.Entities.City", b =>
                {
                    b.Navigation("PointsOfInterest");
                });
#pragma warning restore 612, 618
        }
    }
}
