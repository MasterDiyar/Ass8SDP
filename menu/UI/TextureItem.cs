using Godot.Collections;

namespace Ass67.menu.UI;

using Godot;

public class TextureItem
{
    private Dictionary<string, Texture2D> textures = new Dictionary<string, Texture2D>()
    {
        { "arrow", GD.Load<Texture2D>("res://menu/UI/arrow_attack.png") },
        { "firework", GD.Load<Texture2D>("res://menu/UI/fireworked.png") },
        { "anvil", GD.Load<Texture2D>("res://menu/UI/anvil.png") }
    };

    public Texture2D GetTexture(string textureName)
    {
        return textures[textureName];
    }
}