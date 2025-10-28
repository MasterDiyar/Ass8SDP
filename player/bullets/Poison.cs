using Godot;
using System;
using Ass67.enemy;

public partial class Poison : Node
{
    private Enemy parent;
    [Export]private Timer _timer;
    private float damage = 5;
    private int timesc = 3;

    public override void _Ready()
    {
        parent = GetParent<Enemy>();
        _timer.Start();
        _timer.Timeout += () =>
        {
            if (timesc <= 0) return;
            timesc--;
            parent.DealDamage(damage);
        };
    }
    
    
}
