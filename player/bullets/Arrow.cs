using Godot;
using System;
using Ass67.player.bullets;

public partial class Arrow : Bullet
{
    public override void _Ready()
    {
        base._Ready();
        
    }

    protected override void Die()
    {
        QueueFree();
    }

    protected override void Collide(Area2D area)
    {
        
    }
}
