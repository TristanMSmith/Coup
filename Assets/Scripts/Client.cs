using System;
using UnityEngine;
public class Client : Singleton<Client>
{
    public event EventHandler PhaseChange;
    public Player player { get; private set; }
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

    public void Action()
    {
        phase = Phase.Action;
    }

    public void Counteraction()
    {
        phase = Phase.Counteraction;
    }

    public void Wait()
    {
        phase = Phase.Wait;
    }

    public void SetPhase() { }

    public void Process(Interaction interaction)
    {
        //this should get passed to the Host the attempt to process (Process(Interaction interaction))
        //Debug.Log(Environment.StackTrace);
        //if(interaction)
        interaction.logic?.Invoke();


    }
}
