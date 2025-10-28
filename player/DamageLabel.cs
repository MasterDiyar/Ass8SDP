using Godot;
using System;

public partial class DamageLabel : Label
{
    public double LifeTime = 0.4f;

    public float Angle = 0;

    public override void _Ready()
    {
        Angle = (Angle==0) ? GD.Randf() * Mathf.Pi * 2 : Angle;
    }

    public DamageLabel SetText(string text)
    {
        Text = text;
        return this;
    }

    public override void _Process(double delta)
    {
        Position += new Vector2(Mathf.Cos(Angle), Mathf.Sin(Angle)) * (float)delta * 20;
        LifeTime -= delta;
        if (LifeTime <= 0) QueueFree();
    }
}
