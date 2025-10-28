using System;
using Godot;

namespace Ass67.player;

public partial class AnimationScreen : AnimatedSprite2D
{
    public event Action<float> OnAttack;
    
    protected const string ANIM_RUN = "run";
    protected const string ANIM_IDLE = "idle";
    protected const string ANIM_ATTACK = "attack";

    protected bool _isAttacking = false;

    public override void _Process(double delta)
    {
        HandleMovement();
        HandleAnimation((float)delta);
    }

    protected void HandleMovement()
    {
        if (Input.IsActionPressed("a"))
            Scale = new Vector2(-1, 1);
        else if (Input.IsActionPressed("d"))
            Scale = Vector2.One;
    }

    protected virtual void HandleAnimation(float delta)
    {
        if (!_isAttacking)
        {
            bool isMoving = Input.IsActionPressed("w") ||
                            Input.IsActionPressed("a") ||
                            Input.IsActionPressed("s") ||
                            Input.IsActionPressed("d");

            Play(isMoving ? ANIM_RUN : ANIM_IDLE);
        }
    }

    protected void TriggerAttack(float power = 1f)
    {
        OnAttack?.Invoke(power);
    }
}