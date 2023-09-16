namespace _1_Domain.Models;

public class WeatherRecord
{
    public int Id { get; set; }

    public DateTime RecordedTime { get; set; }

    public int WeatherStationId { get; set; }

    public int VariableId { get; set; }

    public decimal RecordedValue { get; set; }


    public virtual WeatherStation WeatherStation { set; get; }

    public virtual Variable Variable { get; set; }
}