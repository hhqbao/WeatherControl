using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2_Persistent.Migrations
{
    public partial class CreateTableWeatherRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeatherStationId = table.Column<int>(type: "int", nullable: false),
                    VariableId = table.Column<int>(type: "int", nullable: false),
                    RecordedValue = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeatherRecords_Variables_VariableId",
                        column: x => x.VariableId,
                        principalTable: "Variables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeatherRecords_WeatherStations_WeatherStationId",
                        column: x => x.WeatherStationId,
                        principalTable: "WeatherStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeatherRecords_VariableId",
                table: "WeatherRecords",
                column: "VariableId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherRecords_WeatherStationId_VariableId",
                table: "WeatherRecords",
                columns: new[] { "WeatherStationId", "VariableId" });

            migrationBuilder.Sql(@"
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,1,17.09,'2023-08-29 06:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,1,17.22,'2023-08-29 06:05:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,1,17.32,'2023-08-29 06:10:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,1,17.2,'2023-08-29 06:15:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,1,17.17,'2023-08-29 06:20:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,1,17.24,'2023-08-29 06:25:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,1,17.51,'2023-08-29 06:30:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,1,17.84,'2023-08-29 06:35:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,1,17.97,'2023-08-29 06:40:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,1,17.87,'2023-08-29 06:45:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,1,17.62,'2023-08-29 06:50:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,1,17.54,'2023-08-29 06:55:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,2,64,'2023-08-29 06:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,2,47,'2023-08-29 06:05:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,2,46,'2023-08-29 06:10:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,2,56,'2023-08-29 06:15:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,2,60,'2023-08-29 06:20:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,2,58,'2023-08-29 06:25:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,2,54,'2023-08-29 06:30:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,2,55,'2023-08-29 06:35:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,2,56,'2023-08-29 06:40:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,2,54,'2023-08-29 06:45:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,2,60,'2023-08-29 06:50:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(1,2,46,'2023-08-29 06:55:00')

                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,1,19.78,'2023-08-29 02:05:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,1,19.74,'2023-08-29 02:10:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,1,19.8,'2023-08-29 02:15:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,1,19.46,'2023-08-29 02:20:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,1,19.6,'2023-08-29 02:25:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,1,19.14,'2023-08-29 02:30:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,1,19.13,'2023-08-29 02:35:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,1,19.41,'2023-08-29 02:40:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,1,19.78,'2023-08-29 02:45:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,1,19.85,'2023-08-29 02:50:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,1,19.87,'2023-08-29 02:55:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,1,19.93,'2023-08-29 03:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,2,736.3,'2023-08-29 02:05:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,2,736,'2023-08-29 02:10:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,2,734.1,'2023-08-29 02:15:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,2,734,'2023-08-29 02:20:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,2,732.1,'2023-08-29 02:25:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,2,729.5,'2023-08-29 02:30:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,2,727.1,'2023-08-29 02:35:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,2,722.7,'2023-08-29 02:40:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,2,717.7,'2023-08-29 02:45:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,2,713.1,'2023-08-29 02:50:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,2,708.6,'2023-08-29 02:55:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(2,2,702.4,'2023-08-29 03:00:00')

                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,1,19.4833,'2023-08-29 02:05:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,1,19.4439,'2023-08-29 02:10:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,1,19.503,'2023-08-29 02:15:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,1,19.1681,'2023-08-29 02:20:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,1,19.306,'2023-08-29 02:25:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,1,18.8529,'2023-08-29 02:30:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,1,18.84305,'2023-08-29 02:35:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,1,19.11885,'2023-08-29 02:40:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,1,19.4833,'2023-08-29 02:45:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,1,19.55225,'2023-08-29 02:50:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,1,19.57195,'2023-08-29 02:55:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,1,19.63105,'2023-08-29 03:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,2,728.937,'2023-08-29 02:05:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,2,728.64,'2023-08-29 02:10:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,2,726.759,'2023-08-29 02:15:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,2,726.66,'2023-08-29 02:20:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,2,724.779,'2023-08-29 02:25:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,2,722.205,'2023-08-29 02:30:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,2,719.829,'2023-08-29 02:35:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,2,715.473,'2023-08-29 02:40:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,2,710.523,'2023-08-29 02:45:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,2,705.969,'2023-08-29 02:50:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,2,701.514,'2023-08-29 02:55:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(3,2,695.376,'2023-08-29 03:00:00')

                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(4,2,750,'2023-08-29 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(4,2,751.7,'2023-08-29 02:05:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(4,2,754.1,'2023-08-29 02:10:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(4,2,759.6,'2023-08-29 02:15:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(4,2,764.7,'2023-08-29 02:20:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(4,2,780.4,'2023-08-29 02:25:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(4,2,783.1,'2023-08-29 02:30:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(4,2,723.4,'2023-08-29 02:35:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(4,2,748.3,'2023-08-29 02:40:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(4,2,749.1,'2023-08-29 02:45:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(4,2,693.1,'2023-08-29 02:50:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(4,2,753.4,'2023-08-29 02:55:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(4,2,750.6,'2023-08-29 03:00:00')

                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(5,2,738.75,'2023-08-29 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(5,2,740.4245,'2023-08-29 02:05:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(5,2,742.7885,'2023-08-29 02:10:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(5,2,748.206,'2023-08-29 02:15:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(5,2,753.2295,'2023-08-29 02:20:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(5,2,768.694,'2023-08-29 02:25:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(5,2,771.3535,'2023-08-29 02:30:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(5,2,712.549,'2023-08-29 02:35:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(5,2,737.0755,'2023-08-29 02:40:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(5,2,737.8635,'2023-08-29 02:45:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(5,2,682.7035,'2023-08-29 02:50:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(5,2,742.099,'2023-08-29 02:55:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(5,2,739.341,'2023-08-29 03:00:00')

                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(6,2,701.8125,'2023-08-29 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(6,2,703.403275,'2023-08-29 02:05:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(6,2,705.649075,'2023-08-29 02:10:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(6,2,710.7957,'2023-08-29 02:15:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(6,2,715.568025,'2023-08-29 02:20:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(6,2,730.2593,'2023-08-29 02:25:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(6,2,732.785825,'2023-08-29 02:30:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(6,2,676.92155,'2023-08-29 02:35:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(6,2,700.221725,'2023-08-29 02:40:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(6,2,700.970325,'2023-08-29 02:45:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(6,2,648.568325,'2023-08-29 02:50:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(6,2,704.99405,'2023-08-29 02:55:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(6,2,702.37395,'2023-08-29 03:00:00')

                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,3,1.443,'2023-08-29 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,3,1.634,'2023-08-29 02:05:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,3,1.806,'2023-08-29 02:10:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,3,2.642,'2023-08-29 02:15:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,3,2.633,'2023-08-29 02:20:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,3,2.266,'2023-08-29 02:25:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,3,2.716,'2023-08-29 02:30:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,3,2.578,'2023-08-29 02:35:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,3,2.992,'2023-08-29 02:40:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,3,2.395,'2023-08-29 02:45:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,3,2.533,'2023-08-29 02:50:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,3,1.913,'2023-08-29 02:55:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,3,2.237,'2023-08-29 03:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,4,190.4,'2023-08-29 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,4,37.11,'2023-08-29 02:05:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,4,229.1,'2023-08-29 02:10:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,4,303.9,'2023-08-29 02:15:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,4,274.6,'2023-08-29 02:20:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,4,311.9,'2023-08-29 02:25:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,4,322.9,'2023-08-29 02:30:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,4,310.6,'2023-08-29 02:35:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,4,315.1,'2023-08-29 02:40:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,4,298,'2023-08-29 02:45:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,4,292.8,'2023-08-29 02:50:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,4,274.1,'2023-08-29 02:55:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(7,4,295.5,'2023-08-29 03:00:00')

                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,3,2.366,'2023-08-29 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,3,2.234,'2023-08-29 02:05:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,3,2.547,'2023-08-29 02:10:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,3,2.318,'2023-08-29 02:15:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,3,2.618,'2023-08-29 02:20:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,3,1.86,'2023-08-29 02:25:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,3,2.375,'2023-08-29 02:30:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,3,2.079,'2023-08-29 02:35:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,3,2.098,'2023-08-29 02:40:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,3,1.99,'2023-08-29 02:45:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,3,2.21,'2023-08-29 02:50:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,3,2.313,'2023-08-29 02:55:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,3,1.892,'2023-08-29 03:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,4,183.1,'2023-08-29 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,4,210.4,'2023-08-29 02:05:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,4,224.2,'2023-08-29 02:10:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,4,228.6,'2023-08-29 02:15:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,4,188.6,'2023-08-29 02:20:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,4,203.9,'2023-08-29 02:25:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,4,237.8,'2023-08-29 02:30:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,4,260.1,'2023-08-29 02:35:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,4,234.1,'2023-08-29 02:40:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,4,214.4,'2023-08-29 02:45:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,4,270,'2023-08-29 02:50:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,4,230.2,'2023-08-29 02:55:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(8,4,187.6,'2023-08-29 03:00:00')

                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,1,21.88,'2023-08-29 02:05:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,1,21.79,'2023-08-29 02:10:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,1,21.29,'2023-08-29 02:15:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,1,20.81,'2023-08-29 02:20:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,1,20.7,'2023-08-29 02:25:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,1,20.46,'2023-08-29 02:30:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,1,20.25,'2023-08-29 02:35:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,1,20.02,'2023-08-29 02:40:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,1,20.1,'2023-08-29 02:45:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,1,20,'2023-08-29 02:50:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,1,20.14,'2023-08-29 02:55:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,1,19.9,'2023-08-29 03:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,2,120.9,'2023-08-29 02:05:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,2,127.8,'2023-08-29 02:10:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,2,147,'2023-08-29 02:15:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,2,129.3,'2023-08-29 02:20:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,2,110.6,'2023-08-29 02:25:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,2,113.5,'2023-08-29 02:30:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,2,108.6,'2023-08-29 02:35:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,2,114.1,'2023-08-29 02:40:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,2,116.4,'2023-08-29 02:45:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,2,106.5,'2023-08-29 02:50:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,2,103.4,'2023-08-29 02:55:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(9,2,126.6,'2023-08-29 03:00:00')

                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,1,17.71,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,1,17.57,'2023-08-28 02:05:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,1,17.82,'2023-08-28 02:10:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,1,18.4,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,1,18.2,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,1,18.65,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,1,17.87,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,1,18.47,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,1,18.85,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,1,18.48,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,1,18.6,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,1,18.41,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,1,18.57,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,2,746.9,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,2,746.8,'2023-08-28 02:05:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,2,750,'2023-08-28 02:10:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,2,747.8,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,2,743.6,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,2,740.8,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,2,737.2,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,2,735.1,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,2,734.1,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,2,733.6,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,2,728.4,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,2,721.7,'2023-08-28 02:00:00')
                Insert WeatherRecords(WeatherStationId, VariableId, RecordedValue, RecordedTime) Values(10,2,733.4,'2023-08-28 02:00:00')
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherRecords");
        }
    }
}
