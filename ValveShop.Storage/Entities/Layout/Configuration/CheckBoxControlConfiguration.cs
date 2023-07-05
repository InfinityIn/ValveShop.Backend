using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ValveShop.Storage.Entities.Layout.Controls;

namespace ValveShop.Storage.Entities.Layout.Configuration;

public class CheckBoxControlConfiguration : IEntityTypeConfiguration<CheckBoxControl>
{
  public void Configure(EntityTypeBuilder<CheckBoxControl> builder)
  {
    builder.HasKey(x => x.Id);
  }
}
