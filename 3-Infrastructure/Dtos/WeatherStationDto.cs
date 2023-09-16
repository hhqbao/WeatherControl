using _1_Domain.Models;

namespace _3_Infrastructure.Dtos;

public class WeatherStationDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Site { get; set; }

    public string Porfolio { get; set; }

    public string State { get; set; }

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public ICollection<WeatherRecordDto> WeatherRecords { set; get; }

    public WeatherStationDto(WeatherStation station)
    {
        Id = station.Id;
        Name = station.Name;
        Site = station.Site;
        Porfolio = station.Porfolio;
        State = station.State;
        Latitude = station.Latitude;
        Longitude = station.Longitude;

        var lastestRecords = station.WeatherRecords.GroupBy(x => x.VariableId, (key, g) => g.OrderByDescending(y => y.RecordedTime).First()).ToList();
        WeatherRecords = lastestRecords.Select(record => new WeatherRecordDto(record)).ToList();
    }
}