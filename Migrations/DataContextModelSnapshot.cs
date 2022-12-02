﻿// <auto-generated />
using System;
using FlightSearchAssingment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlightSearchAssingment.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("FlightSearchAssingment.Models.Flight", b =>
                {
                    b.Property<string>("FlightId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Adults")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Arrival")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Children")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Departure")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool?>("RoundTrip")
                        .HasColumnType("INTEGER");

                    b.HasKey("FlightId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("FlightSearchAssingment.Models.Itenerary", b =>
                {
                    b.Property<string>("IteneraryID")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("AvailableSeats")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("FlightId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IteneraryID");

                    b.HasIndex("FlightId");

                    b.ToTable("Iteneraries");
                });

            modelBuilder.Entity("FlightSearchAssingment.Models.Prices", b =>
                {
                    b.Property<string>("PricesId")
                        .HasColumnType("TEXT");

                    b.Property<int>("AdultPrice")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChildPrice")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IteneraryID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PricesId");

                    b.HasIndex("IteneraryID");

                    b.ToTable("PriceList");
                });

            modelBuilder.Entity("FlightSearchAssingment.Models.Itenerary", b =>
                {
                    b.HasOne("FlightSearchAssingment.Models.Flight", "Flight")
                        .WithMany("Iteneraries")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("FlightSearchAssingment.Models.Prices", b =>
                {
                    b.HasOne("FlightSearchAssingment.Models.Itenerary", "Itenerary")
                        .WithMany("PriceList")
                        .HasForeignKey("IteneraryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Itenerary");
                });

            modelBuilder.Entity("FlightSearchAssingment.Models.Flight", b =>
                {
                    b.Navigation("Iteneraries");
                });

            modelBuilder.Entity("FlightSearchAssingment.Models.Itenerary", b =>
                {
                    b.Navigation("PriceList");
                });
#pragma warning restore 612, 618
        }
    }
}
