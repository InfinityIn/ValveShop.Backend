using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using ValveShop.Storage.Entities.Layout.Abstract;

namespace ValveShop.Storage.Entities.Layout.Configuration;

public class ProductPropertyConfiguration : IEntityTypeConfiguration<ProductProperty>
{
  public void Configure(EntityTypeBuilder<ProductProperty> builder)
  {
    builder.HasKey(x => x.Id);
  }
}

public class CheckBoxPropertyConfiguration : ProductPropertyConfiguration
{

}

public class RadioGroupPropertyConfiguration : ProductPropertyConfiguration
{

}