using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingAPI.Migrations
{
    /// <inheritdoc />
    public partial class booking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.CreateTable(
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
                name: "TourSpot",
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
                    table.PrimaryKey("PK_TourSpot", x => x.Spot_Id);
                });

            migrationBuilder.CreateTable(
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
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    User_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    HashKey = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.User_Id);
                });

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
                    TourDescription = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Itinerary = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                        name: "FK_Tour_TourSpot_TourSpotSpot_Id",
                        column: x => x.TourSpotSpot_Id,
                        principalTable: "TourSpot",
                        principalColumn: "Spot_Id");
                    table.ForeignKey(
                        name: "FK_Tour_Travel_Agent_Travel_AgentAgent_Id",
                        column: x => x.Travel_AgentAgent_Id,
                        principalTable: "Travel_Agent",
                        principalColumn: "Agent_Id");
                });*/

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Feedback_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TravelerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeedbackMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Feedback_Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_User_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User",
                        principalColumn: "User_Id");
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Booking_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No_of_persons = table.Column<int>(type: "int", nullable: false),
                    TravelerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TravelAgencyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TourPackageId = table.Column<int>(type: "int", nullable: true),
                    BillingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    HotelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransportMode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Travel_AgentAgent_Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Tour_Id = table.Column<int>(type: "int", nullable: true),
                    Hotel_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Booking_Id);
                    table.ForeignKey(
                        name: "FK_Booking_Hotel_Hotel_Id",
                        column: x => x.Hotel_Id,
                        principalTable: "Hotel",
                        principalColumn: "Hotel_Id");
                    table.ForeignKey(
                        name: "FK_Booking_Tour_Tour_Id",
                        column: x => x.Tour_Id,
                        principalTable: "Tour",
                        principalColumn: "Tour_Id");
                    table.ForeignKey(
                        name: "FK_Booking_Travel_Agent_Travel_AgentAgent_Id",
                        column: x => x.Travel_AgentAgent_Id,
                        principalTable: "Travel_Agent",
                        principalColumn: "Agent_Id");
                    table.ForeignKey(
                        name: "FK_Booking_User_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User",
                        principalColumn: "User_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Hotel_Id",
                table: "Booking",
                column: "Hotel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Tour_Id",
                table: "Booking",
                column: "Tour_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Travel_AgentAgent_Id",
                table: "Booking",
                column: "Travel_AgentAgent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_User_Id",
                table: "Booking",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_User_Id",
                table: "Feedbacks",
                column: "User_Id");

     /*       migrationBuilder.CreateIndex(
                name: "IX_Tour_Hotel_Id",
                table: "Tour",
                column: "Hotel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_TourSpotSpot_Id",
                table: "Tour",
                column: "TourSpotSpot_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_Travel_AgentAgent_Id",
                table: "Tour",
                column: "Travel_AgentAgent_Id");*/
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Feedbacks");

/*            migrationBuilder.DropTable(
                name: "Tour");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "TourSpot");

            migrationBuilder.DropTable(
                name: "Travel_Agent");*/
        }
    }
}
