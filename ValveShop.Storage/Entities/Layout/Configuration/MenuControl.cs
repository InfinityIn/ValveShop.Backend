using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using ValveShop.Storage.Entities.Layout.Abstract;

namespace ValveShop.Storage.Entities.Layout.Configuration;

public class MenuControlConfiguration : IEntityTypeConfiguration<MenuControl>
{
    public void Configure(EntityTypeBuilder<MenuControl> builder)
    {
        builder.HasKey(x => x.Id);
    }
}

public class CheckBoxControlConfiguration : MenuControlConfiguration
{

}

public class RadioGroupControlConfiguration : MenuControlConfiguration
{

}

public class ButtonClickControlConfiguration : MenuControlConfiguration
{ 

}