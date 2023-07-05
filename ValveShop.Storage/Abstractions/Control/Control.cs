using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValveShop.Storage.Abstractions.Control
{
    public abstract class Control
    {
        public Control(int id, string name, ControlPlacementType placementType) 
        {
            Id = id;
            Name = name;
            PlacementType = placementType;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ControlPlacementType PlacementType { get; set; }
    }
}
