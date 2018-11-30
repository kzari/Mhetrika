using Microsoft.EntityFrameworkCore.Migrations;

namespace mhetrika.Infrastructure.Migrations
{
    public partial class Int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(byte));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Number",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
