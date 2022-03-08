using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelReservation.Infrastructure.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Maisonettes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaisonetteName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    NumberOfRooms = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maisonettes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaisonetteUser",
                columns: table => new
                {
                    MaisonettesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaisonetteUser", x => new { x.MaisonettesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_MaisonetteUser_Maisonettes_MaisonettesId",
                        column: x => x.MaisonettesId,
                        principalTable: "Maisonettes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaisonetteUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMaisonettes",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MaisonetteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMaisonettes", x => new { x.UserId, x.MaisonetteId });
                    table.ForeignKey(
                        name: "FK_UserMaisonettes_Maisonettes_MaisonetteId",
                        column: x => x.MaisonetteId,
                        principalTable: "Maisonettes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMaisonettes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaisonetteUser_UsersId",
                table: "MaisonetteUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMaisonettes_MaisonetteId",
                table: "UserMaisonettes",
                column: "MaisonetteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaisonetteUser");

            migrationBuilder.DropTable(
                name: "UserMaisonettes");

            migrationBuilder.DropTable(
                name: "Maisonettes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
