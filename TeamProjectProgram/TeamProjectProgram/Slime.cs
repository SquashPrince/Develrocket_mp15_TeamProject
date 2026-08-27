namespace TeamProjectProgram;

public class Slime : Monster, IDamageable
{
    private int _health;
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }

    public Slime(string name) : base(name) { }
}