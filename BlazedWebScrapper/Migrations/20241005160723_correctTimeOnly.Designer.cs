﻿// <auto-generated />
using System;
using BlazedWebScrapper.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazedWebScrapper.Migrations
{
    [DbContext(typeof(WebScrapperDbContext))]
    [Migration("20241005160723_correctTimeOnly")]
    partial class correctTimeOnly
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazedWebScrapper.Entities.FlightModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EndDestination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTripArrival")
                        .HasColumnType("datetime2");

                    b.Property<string>("EndTripDayOfWeek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTripDeparture")
                        .HasColumnType("datetime2");

                    b.Property<float>("EndTripPrice")
                        .HasColumnType("real");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("StartDestination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTripArrival")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartTripDayOfWeek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTripDeparture")
                        .HasColumnType("datetime2");

                    b.Property<float>("StartTripPrice")
                        .HasColumnType("real");

                    b.Property<TimeSpan>("TimeOfEndTrip")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("TimeOfStartTrip")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("FlightModels");
                });
#pragma warning restore 612, 618
        }
    }
}
