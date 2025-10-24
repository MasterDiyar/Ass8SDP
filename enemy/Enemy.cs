using Godot;

namespace Ass67.enemy;

public partial class Enemy : Node2D
{
    public float MaxHp = 100;
    public float Hp = 100;

    public void DealDamage(float damage)
    {
        Hp -= damage;
        if (Hp <= 0)
            QueueFree();
    }
    
}