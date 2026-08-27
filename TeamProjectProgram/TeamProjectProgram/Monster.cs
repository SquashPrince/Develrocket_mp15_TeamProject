using System;

public abstract class Monster : IDamageable, IMoveable, IObservable
{
    public string Name { get; set; } = "";
    public int damage = 1;
    public int Hp { get; set; }
    private int position = 0;

    public int Shell = 40;
    /*public int Shell(int shell)
    {
        Shell = shell;
    }*/

    public Monster(string name)
    {
        Name = name;
    }

    public void Move(int distance)
    {
        position += distance;
        Console.WriteLine($"{Name}이 거리 {distance}만큼 이동해 위치는 {position}입니다.");
    }

    public void TakeDamage(int damage)
    {
        Hp -= damage;
        Console.WriteLine($"{damage}만큼 공격을 받아 HP가{Hp}가 되었습니다.");
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
