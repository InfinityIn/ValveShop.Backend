using System.Collections.Immutable;
using ValveShop.Storage.Abstractions;
using ValveShop.Storage.Abstractions.Control;

namespace ValveShop.Storage.Entities.Layout;
public class TableControl : Control
{
    public TableControl(int id, string name, ControlPlacementType placementType, IReadOnlyList<object> rows)
      : base(id, name, placementType)
    {
        Rows = rows.ToImmutableList();
    }    
    public ImmutableList<object> Rows { get; set; }

}