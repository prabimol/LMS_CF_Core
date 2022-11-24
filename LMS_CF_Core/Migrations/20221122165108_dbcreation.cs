using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS_CF_Core.Migrations
{
    public partial class dbcreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    MobileNo = table.Column<long>(nullable: false),
                    EmailId = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: false),
                    ManagerName = table.Column<string>(nullable: false),
                    Salary = table.Column<float>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
