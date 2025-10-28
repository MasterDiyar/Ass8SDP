using System;
using Godot;

namespace Ass67.enemy;

public partial class Enemy : Node2D
{
    public float MaxHp = 100;
    public float Hp = 100;
    
    public event Action<float> OnHealthChanged;

    public void DealDamage(float damage)
    {
        Hp -= damage;
        
        if (Hp <= 0)
            QueueFree();
        var nid = GD.Load<PackedScene>("res://player/damage_label.tscn")
            .Instantiate<DamageLabel>()
            .SetText(damage.ToString());
        
        nid.Position = GlobalPosition;
        
        GetParent()
            .AddChild(nid);
        
        OnHealthChanged?.Invoke(Hp);
    }
    
}