using Godot;

namespace Ass67.player;

public class UserFactory
{
    public static ArcherUser GetArcher()
    {
        return GD.Load<PackedScene>("res://player/archer_user.tscn").Instantiate<ArcherUser>();
    }

    public static MageUser GetMage()
    {
        return GD.Load<PackedScene>("res://player/mage_user.tscn").Instantiate<MageUser>();
    }

    public static SwordsManUser GetSwordsMan()
    {
        return GD.Load<PackedScene>("res://player/swords_man.tscn").Instantiate<SwordsManUser>();
    }
    
    
}