﻿// <auto-generated />
using System;
using JourneyMentor.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JourneyMentor.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240409220144_Test2")]
    partial class Test2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JourneyMentor.Domain.Entities.Airport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AirportId")
                        .HasColumnType("int");

                    b.Property<string>("AirportName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityIataCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryIso2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeonameId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gmt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IataCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IcaoCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Timezone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Airports");
                });

            modelBuilder.Entity("JourneyMentor.Domain.Entities.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AircraftIata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AircraftIcao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AircraftIcao24")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AircraftRegistration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AirlineIata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AirlineIcao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AirlineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrivalActual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrivalActualRunway")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrivalAirport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrivalBaggage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ArrivalDelay")
                        .HasColumnType("int");

                    b.Property<string>("ArrivalEstimated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrivalEstimatedRunway")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrivalGate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrivalIata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrivalIcao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrivalScheduled")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrivalTerminal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrivalTimezone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureActual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureActualRunway")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureAirport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DepartureDelay")
                        .HasColumnType("int");

                    b.Property<string>("DepartureEstimated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureEstimatedRunway")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureGate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureIata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureIcao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureScheduled")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureTerminal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureTimezone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlightDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlightIata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlightIcao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlightNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlightStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("LiveAltitude")
                        .HasColumnType("real");

                    b.Property<float?>("LiveDirection")
                        .HasColumnType("real");

                    b.Property<bool?>("LiveIsGround")
                        .HasColumnType("bit");

                    b.Property<float?>("LiveLatitude")
                        .HasColumnType("real");

                    b.Property<float?>("LiveLongitude")
                        .HasColumnType("real");

                    b.Property<float?>("LiveSpeedHorizontal")
                        .HasColumnType("real");

                    b.Property<float?>("LiveSpeedVertical")
                        .HasColumnType("real");

                    b.Property<string>("LiveUpdated")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Flights");
                });
#pragma warning restore 612, 618
        }
    }
}