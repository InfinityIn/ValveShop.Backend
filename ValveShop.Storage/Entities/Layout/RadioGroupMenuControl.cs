using ValveShop.Storage.Entities.Layout.Abstract;
using System.Collections.Immutable;

namespace ValveShop.Storage.Entities.Layout;
public class RadioGroupMenuControl : MenuControl
{
    public RadioGroupMenuControl(int _id, string _name, int _defaultValue, IReadOnlyDictionary<string, int> _values)
      : base(_id, _name)
    {
        DefaultValue = _defaultValue;
        Values = _values.ToImmutableDictionary();
    }
    public int DefaultValue { get; set; }
    public ImmutableDictionary<string, int> Values { get; set; }

}