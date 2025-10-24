using Godot;

namespace Ass67.player;

public partial class AnimationScreen : AnimatedSprite2D
{
    private const string ANIM_RUN = "run",
                         ANIM_IDLE = "idle",
                         ANIM_ATTACK = "attack";

    public override void _Process(double delta)
    {
        HandleMovement();
        HandleAnimation();
    }

    private void HandleMovement()
    {
        if (Input.IsActionPressed("a") || Input.IsActionPressed("s"))
            Scale = new Vector2(-1, 1);
        else if (Input.IsActionPressed("d") || Input.IsActionPressed("w"))
            Scale = Vector2.One; 
    }

    private void HandleAnimation()
    {
        if (Input.IsActionPressed("lm"))
        {
            Play(ANIM_ATTACK);
            return;
        }

        bool isMoving = Input.IsActionPressed("w") || 
                        Input.IsActionPressed("a") || 
                        Input.IsActionPressed("s") || 
                        Input.IsActionPressed("d");

        Play(isMoving ? ANIM_RUN : ANIM_IDLE);
    }
}