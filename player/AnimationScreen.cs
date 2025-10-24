using System;
using Godot;

namespace Ass67.player;

public partial class AnimationScreen : AnimatedSprite2D
{
    
    public event Action<float> OnAttack;
    
    private const string ANIM_RUN = "run",
                         ANIM_IDLE = "idle",
                         ANIM_ATTACK = "attack";
    
    public bool _isCharging = false;

    public float _attackCharge = 0,
                 ChargeSpeed = 1,
                 MaxCharge = 10;

    public override void _Process(double delta)
    {
        HandleMovement();
        HandleAnimation((float)delta); 
    }

    private void HandleMovement()
    {
        if (Input.IsActionPressed("a"))
            Scale = new Vector2(-1, 1);
        else if (Input.IsActionPressed("d"))
            Scale = Vector2.One; 
    }

    private void HandleAnimation(float delta)
    {
        if (Input.IsActionPressed("lm"))
        {
            if (!_isCharging)
            {
                _isCharging = true;
                _attackCharge = 0f;
                Play("attack");
            }

            if (Frame == 6)
                Pause(); 
            _attackCharge = Mathf.Min(_attackCharge + ChargeSpeed * delta, MaxCharge);
            
            return;
        }

        if (Input.IsActionJustReleased("lm") && _isCharging)
        {
            GD.Print("I shoot");
            Play();
            
            OnAttack?.Invoke(_attackCharge); 
            _attackCharge = 0f; 
            return;
        }

        if(GetAnimation() == "attack" && Frame == 8)_isCharging = false;

        if (!_isCharging){
            bool isMoving = Input.IsActionPressed("w") ||
                            Input.IsActionPressed("a") ||
                            Input.IsActionPressed("s") ||
                            Input.IsActionPressed("d");

            Play(isMoving ? ANIM_RUN : ANIM_IDLE);
        }
    }
}