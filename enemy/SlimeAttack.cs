using Ass67.player;

namespace Ass67.enemy;
using Godot;
public partial class SlimeAttack : EnemyBullet
{
    public override void _Ready()
    {
        Speed -= 50;
        base._Ready();
    }

    protected override void Penetrate(User user)
    {
        base.Penetrate(user);
        user.GetNode<Movement>("movement").Modifier = 0.8f;
    }
}