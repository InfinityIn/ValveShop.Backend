using Microsoft.EntityFrameworkCore;
using ValveShop.Storage.Entities.Layout;
using ValveShop.Storage.Entities.Layout.Configuration;

namespace ValveShop.Storage
{
  public class StorageContext: DbContext
  {
    public StorageContext()
    {
      Database.EnsureCreated();
    }
    public DbSet<MainMenuItem> MainMenuItems { get; set; }
    public DbSet<FollowedMenuItem> FollowedMenuItems { get; set; }
    public DbSet<CheckBoxProductProperty> CheckBoxProductProperties { get; set; }
    public DbSet<RadioGroupProductProperty> RadioGroupProductProperties { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      builder.ApplyConfiguration(new MainMenuItemConfiguration());
      builder.ApplyConfiguration(new FollowedMenuItemConfiguration());
      builder.ApplyConfiguration(new ProductPropertyConfiguration());
    }
  }
}