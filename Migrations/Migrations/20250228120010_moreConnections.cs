using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrations.Migrations
{
    /// <inheritdoc />
    public partial class moreConnections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupLecture",
                columns: table => new
                {
                    GroupsId = table.Column<int>(type: "int", nullable: false),
                    LecturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupLecture", x => new { x.GroupsId, x.LecturesId });
                    table.ForeignKey(
                        name: "FK_GroupLecture_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupLecture_Lecture_LecturesId",
                        column: x => x.LecturesId,
                        principalTable: "Lecture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupLecture_LecturesId",
                table: "GroupLecture",
                column: "LecturesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupLecture");
        }
    }
}
