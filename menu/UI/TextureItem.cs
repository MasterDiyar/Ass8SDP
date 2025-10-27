using Godot.Collections;

namespace Ass67.menu.UI;

using Godot;

public class TextureItem
{
    public static Dictionary<string, Texture2D> textures = new Dictionary<string, Texture2D>()
    {
        { "arrow", GD.Load<Texture2D>("res://menu/UI/arrow_attack.png") },
        { "firework", GD.Load<Texture2D>("res://menu/UI/fireworked.png") },
        { "anvil", GD.Load<Texture2D>("res://menu/UI/anvil.png") },
        { "poison", GD.Load<Texture2D>("res://menu/UI/poison.png") },
    };

    public static Texture2D GetTexture(string textureName)
    {
        GD.Print("texture name: " + textureName);
        return textures[textureName];
    }
}