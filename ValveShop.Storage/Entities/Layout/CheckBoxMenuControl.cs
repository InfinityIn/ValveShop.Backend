using System.Collections.Immutable;
using ValveShop.Storage.Entities.Layout.Abstract;

namespace ValveShop.Storage.Entities.Layout;

public class CheckBoxMenuControl : MenuControl 
{
    public CheckBoxMenuControl(int _id, string _name, bool _defaultValue) : base(_id, _name)
    {
        DefaultValue = _defaultValue;
    }
    public bool DefaultValue { get; set; }
}

