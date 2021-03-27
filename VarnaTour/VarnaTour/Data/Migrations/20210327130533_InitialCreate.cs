using Microsoft.EntityFrameworkCore.Migrations;

namespace VarnaTour.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beach",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiniContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasRestourant = table.Column<bool>(type: "bit", nullable: false),
                    HasLifeguard = table.Column<bool>(type: "bit", nullable: false),
                    HasMedicalStaff = table.Column<bool>(type: "bit", nullable: false),
                    IsSuitableForChildren = table.Column<bool>(type: "bit", nullable: false),
                    HasDressingRoom = table.Column<bool>(type: "bit", nullable: false),
                    HasShower = table.Column<bool>(type: "bit", nullable: false),
                    HasParking = table.Column<bool>(type: "bit", nullable: false),
                    HasCarAccess = table.Column<bool>(type: "bit", nullable: false),
                    HasUmbrellaAndSunbed = table.Column<bool>(type: "bit", nullable: false),
                    IsDisabilitiesFriendly = table.Column<bool>(type: "bit", nullable: false),
                    BeachType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beach", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beach");
        }
    }
}
