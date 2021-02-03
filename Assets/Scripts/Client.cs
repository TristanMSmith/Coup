using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Client : Singleton<Client>
{
    public event EventHandler PhaseChange;
    public Player player { get; private set; }
    public Opponent opponent;
    public enum Phase { Wait, Action, Counteraction }
    public Phase phase
    {
        get 
        {
            return _phase;
        }
        private set 
        {
            if (value != _phase)
            {
                _phase = value;
                OnPhaseChanged(null);
            }
        }
    }
    private Phase _phase = Phase.Wait;

    public void OnPhaseChanged(EventArgs e)
    {
        PhaseChange?.Invoke(this, e);
    }

    public void SetPhase(Phase Phase) 
    {
        phase = Phase;
    }

    public void Process(Interaction interaction)
    {
        //this should get passed to the Host the attempt to process (Process(Interaction interaction))
        //We should send the opponent as a parameter when we call to process the interaction
        //if(interaction)
        //interaction.logic?.Invoke();
    }
}
