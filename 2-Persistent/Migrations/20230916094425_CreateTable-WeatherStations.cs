using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2_Persistent.Migrations
{
    public partial class CreateTableWeatherStations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherStations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(2000)", nullable: false),
                    Site = table.Column<string>(type: "varchar(2000)", nullable: false),
                    Porfolio = table.Column<string>(type: "varchar(2000)", nullable: false),
                    State = table.Column<string>(type: "varchar(500)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(18,15)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherStations", x => x.Id);
                });

            migrationBuilder.Sql(@"
                Set Identity_Insert WeatherStations ON

                Insert WeatherStations(Id,Name,Site,Porfolio,State,Latitude,Longitude) Values(1,'Cohuna North','Cohuna Solar Farm','Enel Green Power','VIC',-35.882762,144.217208)
                Insert WeatherStations(Id,Name,Site,Porfolio,State,Latitude,Longitude) Values(2,'Bungala 1 West','Bungala 1 Solar Farm','Enel Green Power','SA',-32.430536,137.846245)
                Insert WeatherStations(Id,Name,Site,Porfolio,State,Latitude,Longitude) Values(3,'Bungala 2 East','Bungala 2 Solar Farm','Enel Green Power','SA',-32.405243,137.833565)
                Insert WeatherStations(Id,Name,Site,Porfolio,State,Latitude,Longitude) Values(4,'Parkes North','Parkes Solar Farm','NEOEN','NSW',-33.104181,148.07779)
                Insert WeatherStations(Id,Name,Site,Porfolio,State,Latitude,Longitude) Values(5,'Parkes South','Parkes Solar Farm','NEOEN','NSW',-33.123945,148.077615)
                Insert WeatherStations(Id,Name,Site,Porfolio,State,Latitude,Longitude) Values(6,'Parkes East','Parkes Solar Farm','NEOEN','NSW',33.110485,148.101728)
                Insert WeatherStations(Id,Name,Site,Porfolio,State,Latitude,Longitude) Values(7,'Coopers Gap Mast ','Coopers Gap Wind Farm','AGL','QLD',-26.744933,151.46473)
                Insert WeatherStations(Id,Name,Site,Porfolio,State,Latitude,Longitude) Values(8,'Bulgana Mast','Bulgana Green Power Hub','NEOEN','VIC',-37.062474,142.950079)
                Insert WeatherStations(Id,Name,Site,Porfolio,State,Latitude,Longitude) Values(9,'Childers West','Childers Solar Farm','Atmos','QLD',-25.304253,152.407882)
                Insert WeatherStations(Id,Name,Site,Porfolio,State,Latitude,Longitude) Values(10,'Darlington MS','Darlington Solar Farm','Edify','NSW',-34.647727,146.063079)

                Set Identity_Insert WeatherStations OFF
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherStations");
        }
    }
}
