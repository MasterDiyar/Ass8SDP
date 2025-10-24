using Ass67.player.bullets;
using Godot;

namespace Ass67.player;

public class MageAttack : IAttackStrategy
{
    public PackedScene[] attack { get; set; } = [];

    public void CastAttack(int index, User player)
    {
        var bullet = attack[index].Instantiate<Bullet>();
        bullet.Position = player.GlobalPosition;
        bullet.Rotation = player.GlobalPosition.AngleTo(player.GetGlobalMousePosition());

        player.Mana -= bullet.ManaConsume;
        player.GetParent().AddChild(bullet);
    }
}