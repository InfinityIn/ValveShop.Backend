using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ValveShop.Storage.Entities.Layout.Controls;

namespace ValveShop.Storage.Entities.Layout.Configuration;

public class TableControlConfiguration : IEntityTypeConfiguration<TableControl>
{
  public void Configure(EntityTypeBuilder<TableControl> builder)
  {
    builder.HasKey(x => x.Id);
  }
}
