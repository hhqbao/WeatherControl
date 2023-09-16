using System.Collections.ObjectModel;

namespace _1_Domain.Models;

public class Variable
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string LongName { get; set; }

    public string Unit { get; set; }

    public virtual ICollection<WeatherRecord> WeatherRecords { get; set; }

    public Variable()
    {
        WeatherRecords = new Collection<WeatherRecord>();
    }
}