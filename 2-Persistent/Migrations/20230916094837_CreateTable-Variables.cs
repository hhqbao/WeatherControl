using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2_Persistent.Migrations
{
    public partial class CreateTableVariables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Variables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(500)", nullable: false),
                    LongName = table.Column<string>(type: "varchar(2000)", nullable: false),
                    Unit = table.Column<string>(type: "varchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variables", x => x.Id);
                });

            migrationBuilder.Sql(@"
                Set Identity_Insert Variables ON
                    
                Insert Variables(Id, Name, LongName, Unit) Values(1, 'AirT_inst', 'Air Temp.', 'Deg C')
                Insert Variables(Id, Name, LongName, Unit) Values(2, 'GHI_inst', 'Solar Irrad.', 'W/m^2')
                Insert Variables(Id, Name, LongName, Unit) Values(3, 'WS_avg', 'Wind Speed Avg.', 'm/s')
                Insert Variables(Id, Name, LongName, Unit) Values(4, 'WD_avg', 'Wind Dir. Avg.', 'Deg')         

                Set Identity_Insert Variables OFF
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Variables");
        }
    }
}
