using _1_Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _2_Persistent.Configs;

public class WeatherRecordConfig : IEntityTypeConfiguration<WeatherRecord>
{
    public void Configure(EntityTypeBuilder<WeatherRecord> builder)
    {
        builder.ToTable("WeatherRecords");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.RecordedValue)
            .HasColumnType("decimal(18,4)");

        builder.HasOne(x => x.WeatherStation)
            .WithMany(y => y.WeatherRecords)
            .HasForeignKey(x => x.WeatherStationId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Variable)
            .WithMany(y => y.WeatherRecords)
            .HasForeignKey(x => x.VariableId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(x => new { x.WeatherStationId, x.VariableId });
    }
}