using Godot;

namespace Ass67.player;

public partial class AnimationScreen : AnimatedSprite2D
{
    public override void _Process(double delta)
    {
        if (Input.IsActionPressed("w"))
        {
            Scale = Vector2.One;
        }

        if (Input.IsActionPressed("s"))
        {
            Scale = Vector2.One + Vector2.Left * 2;
        }

        if (Input.IsActionPressed("a"))
        {
            Scale = Vector2.One + Vector2.Left * 2;
        }

        if (Input.IsActionPressed("d"))
        {
            Scale = Vector2.One;
        }
    }
}