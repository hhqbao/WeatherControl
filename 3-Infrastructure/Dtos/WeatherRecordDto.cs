using _1_Domain.Models;

namespace _3_Infrastructure.Dtos;

public class WeatherRecordDto
{
    public int Id { get; set; }

    public DateTime RecordedTime { get; set; }

    public string VariableName { get; set; }

    public string VariableUnit { get; set; }

    public decimal RecordedValue { get; set; }

    public WeatherRecordDto(WeatherRecord record)
    {
        Id = record.Id;
        RecordedTime = record.RecordedTime;
        VariableName = record.Variable.LongName;
        VariableUnit = record.Variable.Unit;
        RecordedValue = record.RecordedValue;
    }
}