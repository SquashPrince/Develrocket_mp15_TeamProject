using System;
using TeamProjectProgram;

public abstract class Monster : IDamageable, IMoveable
{
    public string Name { get; set; } = "";
    public int damage = 1;
    public int Hp { get; set; }
    private int position = 0;

    public void Move(int distance)
    {
        position += distance;
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
