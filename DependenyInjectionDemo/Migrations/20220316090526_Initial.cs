using Microsoft.EntityFrameworkCore.Migrations;

namespace DependenyInjectionDemo.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Batch", "Marks", "Name" },
                values: new object[] { 1, "B001", 90, "Ajay" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Batch", "Marks", "Name" },
                values: new object[] { 2, "B002", 67, "Deepak" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Batch", "Marks", "Name" },
                values: new object[] { 3, "B003", 89, "Sagar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
