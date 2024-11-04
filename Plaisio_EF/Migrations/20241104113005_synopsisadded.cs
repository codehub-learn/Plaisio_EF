using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Plaisio_EF.Migrations
{
    /// <inheritdoc />
    public partial class synopsisadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Synopsae",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriterFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WriterLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Synopsae", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Synopsae_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Synopsae_BookId",
                table: "Synopsae",
                column: "BookId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Synopsae");
        }
    }
}
