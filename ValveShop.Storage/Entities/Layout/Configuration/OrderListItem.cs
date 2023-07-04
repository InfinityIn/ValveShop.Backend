using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ValveShop.Storage.Entities.Layout.Configuration;

public class OrderListItemConfiguration : IEntityTypeConfiguration<OrderListItem>
{
    public void Configure(EntityTypeBuilder<OrderListItem> builder)
    {
        builder.HasKey(x => x.Id);
    }
}