using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoDataGridForSaad.Data.Migrations
{
    public partial class updateCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerTB",
                table: "CustomerTB");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "CustomerTB");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "CustomerTB");

            migrationBuilder.DropColumn(
                name: "City",
                table: "CustomerTB");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "CustomerTB");

            migrationBuilder.DropColumn(
                name: "Phoneno",
                table: "CustomerTB");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CustomerTB",
                newName: "name");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "CustomerTB",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "extn",
                table: "CustomerTB",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "position",
                table: "CustomerTB",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "salary",
                table: "CustomerTB",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "start_date",
                table: "CustomerTB",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerTB",
                table: "CustomerTB",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerTB",
                table: "CustomerTB");

            migrationBuilder.DropColumn(
                name: "id",
                table: "CustomerTB");

            migrationBuilder.DropColumn(
                name: "extn",
                table: "CustomerTB");

            migrationBuilder.DropColumn(
                name: "position",
                table: "CustomerTB");

            migrationBuilder.DropColumn(
                name: "salary",
                table: "CustomerTB");

            migrationBuilder.DropColumn(
                name: "start_date",
                table: "CustomerTB");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "CustomerTB",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "CustomerTB",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "CustomerTB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "CustomerTB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "CustomerTB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phoneno",
                table: "CustomerTB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerTB",
                table: "CustomerTB",
                column: "CustomerID");
        }
    }
}
