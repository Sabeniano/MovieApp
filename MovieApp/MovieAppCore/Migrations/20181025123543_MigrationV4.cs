using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieAppCore.Migrations
{
    public partial class MigrationV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ActorId",
                table: "Movies",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ActorId",
                table: "Movies",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
