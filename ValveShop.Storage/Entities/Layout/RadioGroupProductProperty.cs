using ValveShop.Storage.Entities.Layout.Abstract;
using System.Collections.Immutable;

namespace ValveShop.Storage.Entities.Layout;
public class RadioGroupProductProperty : ProductProperty
{
  public RadioGroupProductProperty(int _id, string _name, int _priority, int _defaultValue, IReadOnlyDictionary<string, int> _values)
    : base(_id, _name, _priority)
  {
    DefaultValue = _defaultValue;
    Values = _values.ToImmutableDictionary();
  }
  public int DefaultValue { get; set; }
  public bool HorizontalLayout { get; set; }
  public ImmutableDictionary<string, int> Values { get; set; }

}
