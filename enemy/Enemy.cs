using System;
using Ass67.player;
using Godot;

namespace Ass67.enemy;

public partial class Enemy : Entity
{


    public override void DealDamage(float damage)
    {
        base.DealDamage(damage);
        if (Hp <= 0)
            QueueFree();
    }
    
}