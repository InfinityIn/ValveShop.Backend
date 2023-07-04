using System.Collections.Immutable;
using ValveShop.Storage.Entities.Layout.Configuration;

namespace ValveShop.Storage.Entities.Layout.Abstract;
public abstract class MenuControl
{
    public MenuControl(int _id, string _name,ButtonClick _buttonClick)
    {
        Id = _id;
        Name = _name;
        ButtonClick = _buttonClick;
    }
    public int Id { get; set; }
    public string Name { get; set; }

    public string ButtonClick{ get; set; }
}

public class ButtonClick
{
    public static implicit operator string(ButtonClick v)
    {
        throw new NotImplementedException();
    }
}