using UnityEngine;
using UnityEngine.Events;

public abstract class Interaction : ScriptableObject
{
    public Sprite sprite;
    public string description;
    public UnityEvent logic;
}