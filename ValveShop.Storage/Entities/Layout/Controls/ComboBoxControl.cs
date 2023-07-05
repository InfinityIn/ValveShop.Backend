using System.Collections.Immutable;
using ValveShop.Storage.Abstractions;
using ValveShop.Storage.Abstractions.Control;

namespace ValveShop.Storage.Entities.Layout;
public class ComboBoxControl : Control
{
    public ComboBoxControl(int id, string name, ControlPlacementType placementType,
        int defaultValue, IReadOnlyList<string> values)
        : base(id, name, placementType)
    {
        DefaultValue = defaultValue;
        Values = values.ToImmutableList();
    }
    public int DefaultValue { get; set; }
    public ImmutableList<string> Values { get; set; }

}