using ValveShop.Storage.Abstractions;
using ValveShop.Storage.Abstractions.Control;

namespace ValveShop.Storage.Entities.Layout.Controls;

public class CheckBoxControl : Control
{
    public CheckBoxControl(int id, string name, ControlPlacementType placementType, bool defaultValue)
        : base(id, name, placementType)
    {
        DefaultValue = defaultValue;
    }
    public bool DefaultValue { get; set; }
}

