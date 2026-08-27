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

    public void TakeDamage(int damAmount)
    {
        _health -= damAmount;
    }
    
}