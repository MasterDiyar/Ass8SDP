using Godot;
using System;

public partial class PlayerUi : CanvasLayer
{
	public Action<int> IndexChanged;
	public override void _Ready()
	{
	}

	
	public override void _Process(double delta)
	{
		Buttons();
	}

	private void Buttons()
	{
		if (Input.IsActionJustPressed("1"))
			IndexChanged?.Invoke(0);
		if (Input.IsActionJustPressed("2"))
			IndexChanged?.Invoke(1);
		if (Input.IsActionJustPressed("3"))
			IndexChanged?.Invoke(2);
	}
}
