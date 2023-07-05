using System.Collections.Immutable;
using ValveShop.Storage.Abstractions;
using ValveShop.Storage.Abstractions.Control;

namespace ValveShop.Storage.Entities.Layout;
public class ImageControl : Control
{
    public ImageControl(int id, string name, ControlPlacementType placementType, string source) 
        : base(id, name, placementType)
    {        
        Source = source;
    }    
    public string Source { get; set; }    
}