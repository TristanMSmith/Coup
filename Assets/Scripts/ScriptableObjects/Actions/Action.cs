using UnityEngine;
[CreateAssetMenu(fileName = "Action", menuName = "ScriptableObjects/Action", order = 1)]
public class Action : ScriptableObject
{
    public Sprite sprite;
    public string description;
    public int creditCost;
    public Counteraction counteraction;
}