using System.Collections.Immutable;
using ValveShop.Storage.Abstractions;
using ValveShop.Storage.Abstractions.Control;

namespace ValveShop.Storage.Entities.Layout;
public class LabelControl : Control
{
    public LabelControl(int id, string name, ControlPlacementType placementType, string value)
      : base(id, name, placementType)
    {
        Value = value;
    }
    public string Value { get; set; }    
}