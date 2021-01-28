using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveOpponents : MonoBehaviour
{
    public GameObject opponentPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //foreach scriptable object in the assets folder, instantiate an interaction prefab
        //and reassign the interactionPrefab's properties to the s.o.'s
        //TODO: Allow the host to decide which interactions are available

        Interaction[] interactions = Resources.LoadAll<Interaction>("ScriptableObjects");
        foreach (Interaction interaction in interactions)
        {
            GameObject interactionGameObject = Instantiate(opponentPrefab, transform);
            B_Interaction b_interaction = interactionGameObject.GetComponent<B_Interaction>();
            b_interaction.interaction = interaction;
            interactionGameObject.name = interaction.name;
        }
    }

    void Add()
    { 
        
    }

    void PopulateTestData()
    { 
        
    }
}
