using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoDataGridForSaad.Data.Migrations
{
    public partial class addednestedobject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "familyId",
                table: "CustomerTB",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Family",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    Kids = table.Column<string>(nullable: true),
                    House = table.Column<string>(nullable: true),
                    Parents = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Family", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTB_familyId",
                table: "CustomerTB",
                column: "familyId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerTB_Family_familyId",
                table: "CustomerTB",
                column: "familyId",
                principalTable: "Family",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerTB_Family_familyId",
                table: "CustomerTB");

            migrationBuilder.DropTable(
                name: "Family");

            migrationBuilder.DropIndex(
                name: "IX_CustomerTB_familyId",
                table: "CustomerTB");

            migrationBuilder.DropColumn(
                name: "familyId",
                table: "CustomerTB");
        }
    }
}
