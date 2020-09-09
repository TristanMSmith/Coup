using System;
using UnityEngine;


public class Client : MonoBehaviour
{
    public event EventHandler PhaseChange;
    public Card[] cards { get; private set; } = new Card[2];
    public Player player { get; private set; } = new Player();
    public enum Phase { Wait, Action, Counteraction }
    public Phase phase
    {
        get 
        {
            return _phase;
        }
        set 
        {
            if (value != _phase)
            {
                _phase = value;
                OnPhaseChanged(null);
            }
        }
    }

    private Phase _phase = Phase.Wait;

    public static Client instance;

    public void OnPhaseChanged(EventArgs e)
    {
        PhaseChange?.Invoke(this, e);
    }
}
