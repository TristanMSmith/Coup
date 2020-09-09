using UnityEngine;
[CreateAssetMenu(fileName = "Action", menuName = "ScriptableObjects/Action", order = 1)]
public class Action : Interaction
{
    public int creditCost;
    public Counteraction counteraction;
}