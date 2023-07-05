using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ValveShop.Storage.Entities.Layout.Controls;

namespace ValveShop.Storage.Entities.Layout.Configuration;

public class LabelControlConfiguration : IEntityTypeConfiguration<LabelControl>
{
  public void Configure(EntityTypeBuilder<LabelControl> builder)
  {
    builder.HasKey(x => x.Id);
  }
}
