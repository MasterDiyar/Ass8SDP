using Ass67.player.bullets;
using Godot;

namespace Ass67.player;

public class ArcherAttack : IAttackStrategy
{
    public ArcherAttack(User him)
    {
        ui = him._playerUI;
        ui.SetText(0, "arrow");
        ui.SetText(1, "firework");
        ui.SetText(2, "poison");
        ui.SetText(3, "anvil");
        ui.InvokeTextChanged();
    }
    private PlayerUi ui;
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