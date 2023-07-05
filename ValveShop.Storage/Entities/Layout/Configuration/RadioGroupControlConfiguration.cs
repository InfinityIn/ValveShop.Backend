using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ValveShop.Storage.Entities.Layout.Controls;

namespace ValveShop.Storage.Entities.Layout.Configuration;

public class RadioGroupControlConfiguration : IEntityTypeConfiguration<RadioGroupControl>
{
  public void Configure(EntityTypeBuilder<RadioGroupControl> builder)
  {
    builder.HasKey(x => x.Id);
  }
}
