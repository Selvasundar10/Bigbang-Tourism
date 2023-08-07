using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tour_API.Migrations
{
    /// <inheritdoc />
    public partial class tour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    Hotel_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hotel_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Contact_Details = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.Hotel_Id);
                });

            migrationBuilder.CreateTable(
                name: "Itinerary",
                columns: table => new
                {
                    Itinerary_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Days = table.Column<int>(type: "int", nullable: false),
                    Activities = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itinerary", x => x.Itinerary_Id);
                });

            migrationBuilder.CreateTable(
                name: "TourSpots",
                columns: table => new
                {
                    Spot_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpotName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourSpots", x => x.Spot_Id);
                });

      /*      migrationBuilder.CreateTable(
                name: "Travel_Agent",
                columns: table => new
                {
                    Agent_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Agent_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agency_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Number = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgencyImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travel_Agent", x => x.Agent_Id);
                });*/

            migrationBuilder.CreateTable(
                name: "Tour",
                columns: table => new
                {
                    Tour_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tour_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tour_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Tour_Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TravelAgencyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Spot_Id = table.Column<int>(type: "int", nullable: false),
                    TourSpotSpot_Id = table.Column<int>(type: "int", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Itinerary_Id = table.Column<int>(type: "int", nullable: true),
                    Travel_AgentAgent_Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Hotel_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour", x => x.Tour_Id);
                    table.ForeignKey(
                        name: "FK_Tour_Hotel_Hotel_Id",
                        column: x => x.Hotel_Id,
                        principalTable: "Hotel",
                        principalColumn: "Hotel_Id");
                    table.ForeignKey(
                        name: "FK_Tour_Itinerary_Itinerary_Id",
                        column: x => x.Itinerary_Id,
                        principalTable: "Itinerary",
                        principalColumn: "Itinerary_Id");
                    table.ForeignKey(
                        name: "FK_Tour_TourSpots_TourSpotSpot_Id",
                        column: x => x.TourSpotSpot_Id,
                        principalTable: "TourSpots",
                        principalColumn: "Spot_Id");
                    table.ForeignKey(
                        name: "FK_Tour_Travel_Agent_Travel_AgentAgent_Id",
                        column: x => x.Travel_AgentAgent_Id,
                        principalTable: "Travel_Agent",
                        principalColumn: "Agent_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tour_Hotel_Id",
                table: "Tour",
                column: "Hotel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_Itinerary_Id",
                table: "Tour",
                column: "Itinerary_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_TourSpotSpot_Id",
                table: "Tour",
                column: "TourSpotSpot_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_Travel_AgentAgent_Id",
                table: "Tour",
                column: "Travel_AgentAgent_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tour");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "Itinerary");

            migrationBuilder.DropTable(
                name: "TourSpots");
/*
            migrationBuilder.DropTable(
                name: "Travel_Agent");*/
        }
    }
}
