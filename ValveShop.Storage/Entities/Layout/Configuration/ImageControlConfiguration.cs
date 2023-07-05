using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ValveShop.Storage.Entities.Layout.Controls;

namespace ValveShop.Storage.Entities.Layout.Configuration;

public class ImageControlConfiguration : IEntityTypeConfiguration<ImageControl>
{
  public void Configure(EntityTypeBuilder<ImageControl> builder)
  {
    builder.HasKey(x => x.Id);
  }
}
