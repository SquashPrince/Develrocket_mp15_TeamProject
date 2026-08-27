using System;
using TeamProjectProgram;

public abstract class Monster : IDamageable, IMoveable
{
    public string Name { get; set; } = "";
    public int damage = 1;
    public int Hp { get; set; }

    public void Move(int distance)
    {
        
    }

    public void TakeDamage(int damage)
    {
        Hp -= damage;
    }

    public bool isDead()
    {
        return true;
    }
}
