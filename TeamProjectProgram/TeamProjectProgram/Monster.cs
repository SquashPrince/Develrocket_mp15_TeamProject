using System;
public abstract class Monster : IObservable
{
    private string _name;
    public string Name
    {
        get
        { 
            return _name;
        }
        set
        { 
            _name = value;
        }
    }

    public Monster(string name)
    {
        Name = name;
    }

    public virtual void OnNotify() { }
}
