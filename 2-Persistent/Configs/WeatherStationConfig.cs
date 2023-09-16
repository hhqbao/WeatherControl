using _1_Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _2_Persistent.Configs;

public class WeatherStationConfig : IEntityTypeConfiguration<WeatherStation>
{
    public void Configure(EntityTypeBuilder<WeatherStation> builder)
    {
        builder.ToTable("WeatherStations");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .HasColumnType("varchar(2000)");

        builder.Property(x => x.Site)
            .HasColumnType("varchar(2000)");

        builder.Property(x => x.Porfolio)
            .HasColumnType("varchar(2000)");

        builder.Property(x => x.State)
            .HasColumnType("varchar(500)");

        builder.Property(x => x.Latitude)
            .HasColumnType("decimal(18,15)");

        builder.Property(x => x.Longitude)
            .HasColumnType("decimal(18,15)");
    }
}