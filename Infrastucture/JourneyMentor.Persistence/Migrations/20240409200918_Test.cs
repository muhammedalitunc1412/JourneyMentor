using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JourneyMentor.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gmt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirportId = table.Column<int>(type: "int", nullable: true),
                    IataCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityIataCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IcaoCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryIso2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeonameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirportName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timezone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureAirport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureTimezone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureIata = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureIcao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureTerminal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureGate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureDelay = table.Column<int>(type: "int", nullable: true),
                    DepartureScheduled = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureEstimated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureActual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureEstimatedRunway = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureActualRunway = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalAirport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalTimezone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalIata = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalIcao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalTerminal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalGate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalBaggage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalDelay = table.Column<int>(type: "int", nullable: true),
                    ArrivalScheduled = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalEstimated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalActual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalEstimatedRunway = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalActualRunway = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirlineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirlineIata = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirlineIcao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightIata = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightIcao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AircraftRegistration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AircraftIata = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AircraftIcao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AircraftIcao24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiveUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiveLatitude = table.Column<float>(type: "real", nullable: true),
                    LiveLongitude = table.Column<float>(type: "real", nullable: true),
                    LiveAltitude = table.Column<float>(type: "real", nullable: true),
                    LiveDirection = table.Column<float>(type: "real", nullable: true),
                    LiveSpeedHorizontal = table.Column<float>(type: "real", nullable: true),
                    LiveSpeedVertical = table.Column<float>(type: "real", nullable: true),
                    LiveIsGround = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.DropTable(
                name: "Flights");
        }
    }
}
