using Godot;
using System;
using Ass67.player;

public partial class UserSelect : Control
{
	private Button Left, Right, Start;
	private AnimatedSprite2D Select;
	private Label Info;

	private int index = 0;

	private string[] About =
	[
		"Archer\n Small elf from magic swamp\n Medium hp, medium speed, has 3 type of attack",
		"Swordsman\n Giant Knight from SilverBread Kingdom\n More hp, speed like cheetah, has sword",
		"Mage\n Old wise gnome from Ruthenia\n Small hp like his speed, has 4 unique spell",
		"archer",
		"swordsman",
		"mage"
	];
	public override void _Ready()
	{
		Init();
	}

	private void Init()
	{
		Select = (AnimatedSprite2D)GetNode("users");
        Info = (Label)GetNode("Label");
        Left = (Button)GetNode("Left");
        Right = (Button)GetNode("Right");
        Start = (Button)GetNode("Start");

        Left.Pressed += ToLeft;
        Right.Pressed += ToRight;
        Start.Pressed += Starting;
        
        Select.Play();
        Selector();
	}

	private void Starting()
	{
		var world = GD.Load<PackedScene>("res://world/game.tscn").Instantiate();
		GetParent().AddChild(world);
		User Player = index switch
		{
			0=>UserFactory.GetArcher(),
			1=>UserFactory.GetMage(),
			2=>UserFactory.GetSwordsMan()
		};
		world.AddChild(Player);
		
		QueueFree();
	}

	void ToLeft()
	{
		index--;
		if (index < 0) index = 2;
		Selector();
	}

	void ToRight()
	{
		index++;
		if (index > 2) index = 0;
		Selector();
	}

	void Selector()
	{
		Info.Text = About[index];
		Select.Animation = About[index + 3];
	}
}
