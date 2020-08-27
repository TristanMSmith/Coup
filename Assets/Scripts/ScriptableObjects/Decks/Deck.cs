using UnityEngine;
[CreateAssetMenu(fileName = "Deck", menuName = "ScriptableObjects/Deck", order = 1)]
public class Deck : ScriptableObject
{
    public DeckCardComponent[] cards;
}
