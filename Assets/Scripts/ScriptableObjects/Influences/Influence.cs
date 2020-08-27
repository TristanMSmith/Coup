using UnityEngine;
[CreateAssetMenu(fileName = "Influence", menuName = "ScriptableObjects/Influence", order = 1)]
public class Influence : ScriptableObject
{
    public Sprite sprite;
    public Action[] actions;
    public Counteraction[] counteractions;
}
