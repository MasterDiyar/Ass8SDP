using Godot;
using System;
using Ass67.player;

public partial class ArcherUser : User
{
    
    public override void _Ready()
    {
        base._Ready();
        _attackStrategy = new ArcherAttack();
        GD.Print("User ready, strategy = ", _attackStrategy);

    }

    public override void RangeLongAttack(float damage)
    {
        GD.Print("Attack");
           _attackStrategy.CastAttack(Index, this, damage);
    }

}
