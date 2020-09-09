using System.Collections.Generic;
using UnityEngine;

public class Controller
{
    public static Controller instance = new Controller();

    public Dictionary<string, Player> players { get; private set; } = new Dictionary<string, Player>();
    public Player currentPlayer;

    void Awake()
    {
        // Forces the screen to be in portrait mode. That's it. Since it's not set to ScreenOrientation.AutoRotation, the device will NOT auto rotate no mater what.
        Screen.orientation = ScreenOrientation.Portrait;

    }
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