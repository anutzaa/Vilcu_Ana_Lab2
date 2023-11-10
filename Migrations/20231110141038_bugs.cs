using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vilcu_Ana_Lab2.Migrations
{
    public partial class bugs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Borrowing_BorrowingID",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_BorrowingID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "BorrowingID",
                table: "Book");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowing_BookID",
                table: "Borrowing",
                column: "BookID");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowing_Book_BookID",
                table: "Borrowing",
                column: "BookID",
                principalTable: "Book",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowing_Book_BookID",
                table: "Borrowing");

            migrationBuilder.DropIndex(
                name: "IX_Borrowing_BookID",
                table: "Borrowing");

            migrationBuilder.AddColumn<int>(
                name: "BorrowingID",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_BorrowingID",
                table: "Book",
                column: "BorrowingID",
                unique: true,
                filter: "[BorrowingID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Borrowing_BorrowingID",
                table: "Book",
                column: "BorrowingID",
                principalTable: "Borrowing",
                principalColumn: "ID");
        }
    }
}
