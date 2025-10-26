using Godot;
using System;
using Ass67.player;

public partial class SwordsManUser : User
{
	public override void _Ready()
	{
		base._Ready();
		_attackStrategy = new ArcherAttack();

	}

	public override void RangeLongAttack(float damage)
	{
		_attackStrategy.CastAttack(Index, this, damage);
	}
}
