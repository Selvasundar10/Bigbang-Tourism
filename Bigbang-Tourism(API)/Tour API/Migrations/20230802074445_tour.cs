using System;
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
            //migrationBuilder.CreateTable(
            //    name: "Gallery",
            //    columns: table => new
            //    {
            //        Image_Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Gallery", x => x.Image_Id);
            //    });

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

            //migrationBuilder.CreateTable(
            //    name: "User",
            //    columns: table => new
            //    {
            //        User_Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        User_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Role = table.Column<int>(type: "int", nullable: false),
            //        Image_Id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_User", x => x.User_Id);
            //        table.ForeignKey(
            //            name: "FK_User_Gallery_Image_Id",
            //            column: x => x.Image_Id,
            //            principalTable: "Gallery",
            //            principalColumn: "Image_Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Feedback",
            //    columns: table => new
            //    {
            //        Feedback_Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        User_Id = table.Column<int>(type: "int", nullable: false),
            //        FeedbackMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Rating = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Feedback", x => x.Feedback_Id);
            //        table.ForeignKey(
            //            name: "FK_Feedback_User_User_Id",
            //            column: x => x.User_Id,
            //            principalTable: "User",
            //            principalColumn: "User_Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Travel_Agent",
            //    columns: table => new
            //    {
            //        Agent_Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        User_Id = table.Column<int>(type: "int", nullable: false),
            //        Agency_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        Contact_Number = table.Column<int>(type: "int", nullable: false),
            //        Status = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Travel_Agent", x => x.Agent_Id);
            //        table.ForeignKey(
            //            name: "FK_Travel_Agent_User_User_Id",
            //            column: x => x.User_Id,
            //            principalTable: "User",
            //            principalColumn: "User_Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            migrationBuilder.CreateTable(
                name: "Tour",
                columns: table => new
                {
                    Tour_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Agent_Id = table.Column<int>(type: "int", nullable: false),
                    Tour_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Itinerary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tour_Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hotel_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour", x => x.Tour_Id);
                    table.ForeignKey(
                        name: "FK_Tour_Hotel_Hotel_Id",
                        column: x => x.Hotel_Id,
                        principalTable: "Hotel",
                        principalColumn: "Hotel_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tour_Travel_Agent_Agent_Id",
                        column: x => x.Agent_Id,
                        principalTable: "Travel_Agent",
                        principalColumn: "Agent_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking_Details",
                columns: table => new
                {
                    Booking_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Agent_Id = table.Column<int>(type: "int", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: true),
                    Tour_Id = table.Column<int>(type: "int", nullable: true),
                    Hotel_Id = table.Column<int>(type: "int", nullable: true),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BillingDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    no_of_persons = table.Column<int>(type: "int", nullable: false),
                    BillingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking_Details", x => x.Booking_Id);
                    table.ForeignKey(
                        name: "FK_Booking_Details_Hotel_Hotel_Id",
                        column: x => x.Hotel_Id,
                        principalTable: "Hotel",
                        principalColumn: "Hotel_Id");
                    table.ForeignKey(
                        name: "FK_Booking_Details_Tour_Tour_Id",
                        column: x => x.Tour_Id,
                        principalTable: "Tour",
                        principalColumn: "Tour_Id");
                    table.ForeignKey(
                        name: "FK_Booking_Details_User_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User",
                        principalColumn: "User_Id");
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
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tour_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourSpots", x => x.Spot_Id);
                    table.ForeignKey(
                        name: "FK_TourSpots_Tour_Tour_Id",
                        column: x => x.Tour_Id,
                        principalTable: "Tour",
                        principalColumn: "Tour_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Details_Hotel_Id",
                table: "Booking_Details",
                column: "Hotel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Details_Tour_Id",
                table: "Booking_Details",
                column: "Tour_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Details_User_Id",
                table: "Booking_Details",
                column: "User_Id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Feedback_User_Id",
            //    table: "Feedback",
            //    column: "User_Id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Tour_Agent_Id",
            //    table: "Tour",
            //    column: "Agent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_Hotel_Id",
                table: "Tour",
                column: "Hotel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TourSpots_Tour_Id",
                table: "TourSpots",
                column: "Tour_Id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Travel_Agent_User_Id",
            //    table: "Travel_Agent",
            //    column: "User_Id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_User_Image_Id",
            //    table: "User",
            //    column: "Image_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking_Details");

            //migrationBuilder.DropTable(
            //    name: "Feedback");

            migrationBuilder.DropTable(
                name: "TourSpots");

            migrationBuilder.DropTable(
                name: "Tour");

            migrationBuilder.DropTable(
                name: "Hotel");

            //migrationBuilder.DropTable(
            //    name: "Travel_Agent");

            //migrationBuilder.DropTable(
            //    name: "User");

            //migrationBuilder.DropTable(
            //    name: "Gallery");
        }
    }
}
