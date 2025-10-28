using Godot;
using System;
using Ass67.player;
using Ass67.player.bullets;

public partial class EnemyBullet : Bullet
{
    protected override void Collide(Area2D area)
    {
        if (area.GetParent() is Entity user)
            Penetrate(user);
    }

    protected virtual void Penetrate(Entity user)
    {
        user.DealDamage(Damage);
    }
}
