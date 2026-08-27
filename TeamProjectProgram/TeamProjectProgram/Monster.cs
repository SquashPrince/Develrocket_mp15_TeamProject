using System;

using TeamProjectProgram;

public abstract class Monster : IDamageable, IMoveable, IObservable
{
    public string Name { get; set; } = "";
    public int damage = 1;
    public int Hp { get; set; }
    private int position = 0;

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

    public virtual void OnNotify()
    {
        if(Hp >= 0)
        {
            Console.WriteLine($"{Name} : 남은 체력 {Hp}");
        }
        else
        {
            Console.WriteLine($"{Name}은 죽었습니다.");
        }

    }
}
