using Godot;
using System;

public partial class FireworkArrow : Arrow
{
    public override void _Ready()
    {
        Speed = 200;
        base._Ready();
    }

    public override void _Process(double d)
    {
        Speed += 10;
        base._Process(d);
    }

    protected override void Die()
    {
        var Boom = GD.Load<PackedScene>("res://player/bullets/boom.tscn").Instantiate<Boom>();
        Boom.Position = GlobalPosition;
        
        GetParent().CallDeferred("add_child", Boom);
        base.Die();
    }
}
