using Godot;
using System;
using Ass67.player.bullets;

public abstract partial class User : Node2D
{

    public  float MaxHp  = 100;
    public  float MaxMp  = 100;
    public float MaxMana = 100;
    public float Mana = 100;
    
    public event Action<int> OnHealthChange;
    public event Action<int> OnManaChange;
    public event Action Attacking;

    public virtual void CastAttack(PackedScene attack)
    {
        var bullet = attack.Instantiate<Bullet>();
        bullet.Position = GlobalPosition;
        bullet.Rotation = GlobalPosition.AngleTo(GetGlobalMousePosition());

        Mana -= bullet.ManaConsume;
        GetParent().AddChild(bullet);
    }
}
