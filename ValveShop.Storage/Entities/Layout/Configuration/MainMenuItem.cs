using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ValveShop.Storage.Entities.Layout.Configuration;

public class MainMenuItemConfiguration : IEntityTypeConfiguration<MainMenuItem>
{
  public void Configure(EntityTypeBuilder<MainMenuItem> builder)
  {
    builder.HasKey(x => x.Id);
  }
}
