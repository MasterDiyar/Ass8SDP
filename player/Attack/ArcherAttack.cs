using Ass67.player.bullets;
using Godot;

namespace Ass67.player;

public class ArcherAttack : IAttackStrategy
{
    public PackedScene[] attack { get; set; } = [GD.Load<PackedScene>("res://player/bullets/Arrow.tscn")];
    
    
    public void CastAttack(int index, User player, float damage)
    {
        index = Mathf.Clamp(index, 0, attack.Length - 1);
        
        var bullet = attack[index].Instantiate<Bullet>();
        bullet.Position = player.GlobalPosition;
        bullet.Rotation =  (player.GetGlobalMousePosition() - player.GlobalPosition).Angle();

        player.Mana -= bullet.ManaConsume;
        player.GetParent().AddChild(bullet);
    }
}