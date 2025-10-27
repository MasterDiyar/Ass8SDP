using Godot;
using System;

public partial class PlayerUi : CanvasLayer
{
	public Action<int> IndexChanged;
	public Action TextChanged;
	public override void _Ready()
	{
	}

	public void SetText(int index, string text)
	{
		foreach (var node in GetNode("Control").GetChildren())
		{
			var frame = (AbilityFrame)node;
			if (frame.Index == index)
				frame.ItemName = text;
		}
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

	public void InvokeTextChanged()
	{
		TextChanged?.Invoke();
	}
}
