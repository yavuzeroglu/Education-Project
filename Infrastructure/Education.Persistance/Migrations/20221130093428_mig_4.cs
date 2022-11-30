using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Education.Persistance.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentFileSubject",
                columns: table => new
                {
                    DocumentFilesId = table.Column<int>(type: "int", nullable: false),
                    SubjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentFileSubject", x => new { x.DocumentFilesId, x.SubjectsId });
                    table.ForeignKey(
                        name: "FK_DocumentFileSubject_Files_DocumentFilesId",
                        column: x => x.DocumentFilesId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentFileSubject_Subjects_SubjectsId",
                        column: x => x.SubjectsId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectSubjectImageFile",
                columns: table => new
                {
                    SubjectImageFilesId = table.Column<int>(type: "int", nullable: false),
                    SubjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectSubjectImageFile", x => new { x.SubjectImageFilesId, x.SubjectsId });
                    table.ForeignKey(
                        name: "FK_SubjectSubjectImageFile_Files_SubjectImageFilesId",
                        column: x => x.SubjectImageFilesId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectSubjectImageFile_Subjects_SubjectsId",
                        column: x => x.SubjectsId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentFileSubject_SubjectsId",
                table: "DocumentFileSubject",
                column: "SubjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectSubjectImageFile_SubjectsId",
                table: "SubjectSubjectImageFile",
                column: "SubjectsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentFileSubject");

            migrationBuilder.DropTable(
                name: "SubjectSubjectImageFile");

            migrationBuilder.DropTable(
                name: "Files");
        }
    }
}
