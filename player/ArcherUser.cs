using Godot;
using System;

public partial class ArcherUser : User
{
    [Export] AnimatedSprite2D
    _buhoi;
    public override void _Ready()
    {
        base._Ready();
        _buhoi.Play("Idle");
    }
}
