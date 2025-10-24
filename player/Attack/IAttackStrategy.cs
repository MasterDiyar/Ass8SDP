using Godot;

namespace Ass67.player;

public interface IAttackStrategy
{
    PackedScene[] attack {get; set;}
    void CastAttack(int index, User Player, float damage);
}