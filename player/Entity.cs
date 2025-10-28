using System;
using Godot;

namespace Ass67.player;

public partial class Entity : Node2D
{
    public float MaxHp = 100;
    public float Hp = 100;
    
    public event Action<float> OnHealthChanged;

    public virtual void DealDamage(float damage)
    {
        Hp -= damage;
        
        var nid = GD
            .Load<PackedScene>("res://player/damage_label.tscn")
            .Instantiate<DamageLabel>()
            .SetText(damage.ToString());
                
        nid.Position = GlobalPosition;
                
        GetParent().AddChild(nid);
        
        OnHealthChanged?.Invoke(Hp);
    }
}