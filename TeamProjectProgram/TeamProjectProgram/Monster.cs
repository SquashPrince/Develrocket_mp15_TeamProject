using System;

using TeamProjectProgram;

public abstract class Monster : IDamageable, IMoveable, IObservable
{
    public string Name { get; set; } = "";
    public int damage = 1;
    public int Hp { get; set; }
    private int position = 0;

    public int Shell = 40;

    public Monster(string name)
    {
        Name = name;
    }

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

    public int Shell(int shell)
    {
        Shell = shell;
    }

    public virtual void OnNotify();
}
