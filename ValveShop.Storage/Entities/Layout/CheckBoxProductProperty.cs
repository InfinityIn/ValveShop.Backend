using System.Collections.Immutable;
using ValveShop.Storage.Entities.Layout.Abstract;

namespace ValveShop.Storage.Entities.Layout;

public class CheckBoxProductProperty : ProductProperty
{
  public CheckBoxProductProperty(int _id, string _name, int _priority, bool _defaultValue) : base(_id, _name, _priority)
  {
    DefaultValue = _defaultValue;
  }
  public bool DefaultValue { get; set; }
}

