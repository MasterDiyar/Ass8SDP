using Godot;
using System;
using Ass67.player.bullets;

public partial class Arrow : Bullet
{

    protected override void Die()
    {
        QueueFree();
    }

    protected override void Collide(Area2D area)
    {
        base.Collide(area);
        if (area.GetParent() is not User)Die();
    }
}
