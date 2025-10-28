using Godot;
using System;
using Ass67.enemy;

public partial class HpLine : Line2D
{
    Enemy Mob;
    
    public override void _Ready()
    {
        Mob  = GetParent() as Enemy;
        Position = Vector2.Up*16;
        Mob.OnHealthChanged += HpChanged;
    }

    private void HpChanged(float dmg)
    {
        var a = Mathf.Clamp(Mob.Hp / Mob.MaxHp, 0, 1);
        SetPointPosition(1, -20 * Vector2.Right+40*a*Vector2.Right);
    }
}
