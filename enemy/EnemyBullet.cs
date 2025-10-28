using Godot;
using System;
using Ass67.player.bullets;

public partial class EnemyBullet : Bullet
{
    protected override void Collide(Area2D area)
    {
        if (area.GetParent() is User user)
            Penetrate(user);
    }

    protected virtual void Penetrate(User user)
    {
        user.GetHurt(Damage);
    }
}
