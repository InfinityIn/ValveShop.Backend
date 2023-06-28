using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ValveShop.Storage.Entities.Layout.Configuration;

public class FollowedMenuItemConfiguration : IEntityTypeConfiguration<FollowedMenuItem>
{
  public void Configure(EntityTypeBuilder<FollowedMenuItem> builder)
  {
    builder.HasKey(x => x.Id);
  }
}
