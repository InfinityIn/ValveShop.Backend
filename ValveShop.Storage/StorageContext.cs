using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ValveShop.Storage.Entities.Layout;
using ValveShop.Storage.Entities.Layout.Configuration;
using ValveShop.Storage.Entities.Layout.Controls;

namespace ValveShop.Storage
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<CheckBoxControl> CheckBoxControls { get; set; }
        public DbSet<ComboBoxControl> ComboBoxControls { get; set; }
        public DbSet<ImageControl> ImageControls { get; set; }
        public DbSet<LabelControl> LabelControls { get; set; }
        public DbSet<RadioGroupControl> RadioGroupControls { get; set; }
        public DbSet<TableControl> TableControls { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CheckBoxControlConfiguration());
            builder.ApplyConfiguration(new ComboBoxControlConfiguration());
            builder.ApplyConfiguration(new ImageControlConfiguration());
            builder.ApplyConfiguration(new LabelControlConfiguration());
            builder.ApplyConfiguration(new RadioGroupControlConfiguration());
            builder.ApplyConfiguration(new TableControlConfiguration());
        }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
    
    }
}