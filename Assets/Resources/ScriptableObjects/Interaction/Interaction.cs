using UnityEngine;

public abstract class Interaction : ScriptableObject
{
    public Sprite sprite;
    public string description;
    public System.Action logic;
}