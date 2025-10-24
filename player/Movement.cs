using Godot;

namespace Ass67.player;

public partial class Movement : Node
{
    [Export(hintString:"Test Export String")] private User Player;

    [Export] public float Speed = 200f;
    [Export] public float Modifier = 1f;

    public override void _Process(double delta)
    {
        Vector2 dir = new Vector2(
            Input.IsActionPressed("d") ? 1 : Input.IsActionPressed("a") ? -1 : 0,
            Input.IsActionPressed("s") ? 1 : Input.IsActionPressed("w") ? -1 : 0
        ).Normalized();
        Player.Position += dir * Speed * Modifier * (float)delta;
    }
}