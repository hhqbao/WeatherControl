using _1_Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _2_Persistent.Configs;

public class VariableConfig : IEntityTypeConfiguration<Variable>
{
    public void Configure(EntityTypeBuilder<Variable> builder)
    {
        builder.ToTable("Variables");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .HasColumnType("varchar(500)");

        builder.Property(x => x.LongName)
            .HasColumnType("varchar(2000)");

        builder.Property(x => x.Unit)
            .HasColumnType("varchar(500)");
    }
}