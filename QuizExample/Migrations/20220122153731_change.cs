using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizExample.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Question",
                table: "Answer");

            migrationBuilder.AddColumn<int>(
                name: "QuestionID",
                table: "Answer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionID",
                table: "Answer");

            migrationBuilder.AddColumn<int>(
                name: "Question",
                table: "Answer",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
