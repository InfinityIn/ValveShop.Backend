using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ValveShop.Storage.Entities.Layout.Controls;

namespace ValveShop.Storage.Entities.Layout.Configuration;

public class ComboBoxControlConfiguration : IEntityTypeConfiguration<ComboBoxControl>
{
  public void Configure(EntityTypeBuilder<ComboBoxControl> builder)
  {
    builder.HasKey(x => x.Id);
  }
}
