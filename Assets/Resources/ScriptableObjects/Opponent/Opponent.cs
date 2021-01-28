using UnityEngine;
public class Opponent
{
    public string name { get; private set; }
    public Sprite sprite { get; private set; }

    public Opponent(string Name, Sprite Sprite)
    {
        name = Name;
        sprite = Sprite;
    }
}