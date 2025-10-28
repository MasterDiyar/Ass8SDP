using Godot;
using System;
using Ass67.enemy;

public partial class PoisonArrow : Arrow
{
    [Export]private PackedScene poison;
    protected override void Collide(Area2D area)
    {
        
        if (area.GetParent() is Enemy en){
            en.DealDamage(Damage);
            var node = poison.Instantiate<Poison>();
            en.AddChild(node);
            Die();
        }
        
    }
}
