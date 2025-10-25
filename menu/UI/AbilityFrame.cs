using Godot;
using System;

public partial class AbilityFrame : TextureRect
{
	[Export] private int Index = 0;
	[Export] private string Name = "";
	private TextureRect  _itemRect;
	private Texture2D notChoosen, choosen;
	private PlayerUi _ui;
	public override void _Ready()
	{
		Init();
	}

	public void Init()
	{
		_ui        = GetParent<PlayerUi>();
		_itemRect  = GetNode<TextureRect>("icon");
		notChoosen = GD.Load<Texture2D>("res://menu/UI/hz.png");
		choosen    = GD.Load<Texture2D>("res://menu/UI/hz_chooze.png");

		_ui.IndexChanged += CheckChange;
	}

	public void CheckChange(int index)
	{
		_itemRect.SetTexture(index != Index ? notChoosen : choosen);
	}

	public override void _Process(double delta)
	{
	}
}
