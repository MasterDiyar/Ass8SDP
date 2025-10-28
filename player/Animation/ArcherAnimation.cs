namespace Ass67.player.Animation;

using Godot;
public partial class ArcherAnimation : AnimationScreen
{
    private bool  _isCharging = false;
    private float _attackCharge = 0f;
    [Export] public float ChargeSpeed = 1f;
    [Export] public float MaxCharge = 10f;

    protected override void HandleAnimation(float delta)
    {
        if (Input.IsActionPressed("lm"))
        {
            if (!_isCharging)
            {
                _isCharging = true;
                _attackCharge = 0f;
                _isAttacking = true;
                Play(ANIM_ATTACK);
            }

            if (Frame == 6)
                Pause();

            _attackCharge = Mathf.Min(_attackCharge + ChargeSpeed * delta, MaxCharge);
            return;
        }

        if (Input.IsActionJustReleased("lm") && _isCharging)
        {
            Play();
            _isCharging = false;
            return;
        }

        if (GetAnimation() == ANIM_ATTACK && Frame == 8)
        {
            _isAttacking = false;
            TriggerAttack(_attackCharge);
        }

        base.HandleAnimation(delta);
    } 
}