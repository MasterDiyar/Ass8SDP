using Godot;
using System;

public partial class HpLine : Line2D
{
    User Player;
    
    public override void _Ready()
    {
        Player  = GetParent() as User;
        Position = Vector2.Up*20;
        Player.OnHealthChange += HpChanged;
    }

    private void HpChanged(float dmg)
    {
        var a = Mathf.Clamp(Player.Hp / Player.MaxHp, 0, 1);
        SetPointPosition(1, -20 * Vector2.Right+40*a*Vector2.Right);
    }
}
