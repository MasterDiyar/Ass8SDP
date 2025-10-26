using Godot;
using System;
using Ass67.player;
using Ass67.player.bullets;

public abstract partial class User : Node2D
{
    [Export]
    private AnimationScreen _Anim;

    protected IAttackStrategy _attackStrategy;
    public PlayerUi _playerUI;
    public  float MaxHp  = 100,
                  Hp  = 100,
                  MaxMana = 100,
                  Mana = 100;

    public int Index = 0;
    
    public event Action<float> OnHealthChange;
    public event Action<float> OnManaChange;

    public override void _Ready()
    {
        GD.Print("User Ready");
        _Anim.OnAttack += RangeLongAttack;
    }
    
    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("1")) Index = 0;
        if (Input.IsActionJustPressed("2")) Index = 1;
        if (Input.IsActionJustPressed("3")) Index = 2;
    }

    public abstract void RangeLongAttack(float damage);

    public virtual void GetHurt(float damage)
    {
        Hp -= damage;
        OnHealthChange?.Invoke(Hp); 
    }
    
    
}
