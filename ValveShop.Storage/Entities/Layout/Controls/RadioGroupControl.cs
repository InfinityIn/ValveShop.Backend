using System.Collections.Immutable;
using ValveShop.Storage.Abstractions;
using ValveShop.Storage.Abstractions.Control;

namespace ValveShop.Storage.Entities.Layout.Controls;
public class RadioGroupControl : Control
{
    public RadioGroupControl(int id, string name, ControlPlacementType placementType,
        int defaultValue, IReadOnlyDictionary<string, int> values)
        : base(id, name, placementType)
    {
        DefaultValue = defaultValue;
        Values = values.ToImmutableDictionary();
    }
    public int DefaultValue { get; set; }
    public ImmutableDictionary<string, int> Values { get; set; }

}