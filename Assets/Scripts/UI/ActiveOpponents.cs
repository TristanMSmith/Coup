using System.Collections.Generic;
using UnityEngine;

public class ActiveOpponents : Singleton<ActiveOpponents>
{
    
    public B_Opponent selectedOpponent { get; private set; }
    List<B_Opponent> opponents = new List<B_Opponent>();
    public GameObject opponentPrefab;
	// Start is called before the first frame update


	void Add()
    { 
        
    }

    void PopulateTestData()
    { 
        
    }
    void DeselectOpponents()
    {
        
    }
}
