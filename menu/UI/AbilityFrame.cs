using Godot;
using System;
using Ass67.menu.UI;

public partial class AbilityFrame : TextureRect
{
	[Export] public  int Index = 0;
	[Export] public string ItemName = "";
	private TextureRect  _itemRect;
	private Texture2D notChoosen, choosen;
	private PlayerUi _ui;
	public override void _Ready()
	{
		Init();
	}

	public void Init()
	{
		_ui        = GetParent().GetParent<PlayerUi>();
		_itemRect  = GetNode<TextureRect>("icon");
		notChoosen = GD.Load<Texture2D>("res://menu/UI/hz.png");
		choosen    = GD.Load<Texture2D>("res://menu/UI/hz_chooze.png");

		_ui.IndexChanged += CheckChange;
		_ui.TextChanged += () => { _itemRect.SetTexture(TextureItem.GetTexture(ItemName));};
	}

	public void CheckChange(int index)
	{
		SetTexture(index != Index ? notChoosen : choosen);
	}

}
