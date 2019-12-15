using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class drop_orat_student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orar_Student_StudentId",
                table: "Orar");

            migrationBuilder.DropIndex(
                name: "IX_Orar_StudentId",
                table: "Orar");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Orar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "Orar",
                type: "varchar(10) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orar_StudentId",
                table: "Orar",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orar_Student_StudentId",
                table: "Orar",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
