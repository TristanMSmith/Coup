using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller
{
    public static Controller instance = new Controller();

    public Dictionary<string, Player> players { get; private set; } = new Dictionary<string, Player>();
    public Player currentPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void EndTurn()
    {
        
    }



    void StartRound()
    {
        
    }
}