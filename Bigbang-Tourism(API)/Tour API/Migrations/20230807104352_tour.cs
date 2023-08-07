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
          /*  migrationBuilder.CreateTable(
                name: "Travel_Agent",
                columns: table => new
                {
                    Agent_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Agent_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agency_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Number = table.Column<int>(type: "int", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgencyImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Tour_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tour_Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TravelAgencyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Travel_AgentAgent_Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour", x => x.Tour_Id);
                    table.ForeignKey(
                        name: "FK_Tour_Travel_Agent_Travel_AgentAgent_Id",
                        column: x => x.Travel_AgentAgent_Id,
                        principalTable: "Travel_Agent",
                        principalColumn: "Agent_Id");
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    Hotel_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hotel_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Contact_details = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Location = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: true),
                    Tour_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.Hotel_id);
                    table.ForeignKey(
                        name: "FK_Hotel_Tour_Tour_Id",
                        column: x => x.Tour_Id,
                        principalTable: "Tour",
                        principalColumn: "Tour_Id");
                });

            migrationBuilder.CreateTable(
                name: "Itinerary",
                columns: table => new
                {
                    Itinerary_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Days = table.Column<int>(type: "int", nullable: true),
                    Activities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tour_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itinerary", x => x.Itinerary_Id);
                    table.ForeignKey(
                        name: "FK_Itinerary_Tour_Tour_Id",
                        column: x => x.Tour_Id,
                        principalTable: "Tour",
                        principalColumn: "Tour_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_Tour_Id",
                table: "Hotel",
                column: "Tour_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Itinerary_Tour_Id",
                table: "Itinerary",
                column: "Tour_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_Travel_AgentAgent_Id",
                table: "Tour",
                column: "Travel_AgentAgent_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "Itinerary");

            migrationBuilder.DropTable(
                name: "Tour");
/*
            migrationBuilder.DropTable(
                name: "Travel_Agent");*/
        }
    }
}
