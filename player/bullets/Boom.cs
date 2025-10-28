using Godot;
using System;
using Ass67.player.bullets;

public partial class Boom : Bullet
{

    public override void _Ready()
    {
        Damage = 60;
        LifeTime = 0.3f;
        base._Ready();
    }

    public override void _Process(double delta) { }
}
