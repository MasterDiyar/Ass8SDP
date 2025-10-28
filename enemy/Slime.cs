using Godot;

namespace Ass67.enemy;

public partial class Slime : Enemy
{
    public override void _Ready()
    {
        GetNode<AnimatedSprite2D>("AnimatedSprite2D").Play();
    }
}