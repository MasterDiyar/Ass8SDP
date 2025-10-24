namespace Ass67.player.bullets;
using Godot;
public partial class Bullet : Node2D
{
    public float ManaConsume = 10;
    public float Speed = 350;
    public float LifeTime = 1;
    public float Damage = 20;

    [Export] private Timer  _timer;
    [Export] private Area2D _area;

    public override void _Ready()
    {
        _timer.WaitTime = LifeTime;
        _timer.Timeout += Die;
        _area.AreaEntered += Collide;
    }

    public override void _Process(double d)
    {
        Position += new Vector2(Mathf.Cos(Rotation), Mathf.Sin(Rotation)) *  Speed * (float)d;
    }

    protected virtual void Die(){QueueFree();}
    protected virtual void Collide(Area2D area){}
    
    
}