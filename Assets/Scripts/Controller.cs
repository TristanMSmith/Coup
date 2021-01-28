using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : Singleton<Controller>
{

    public Dictionary<string, Player> players { get; private set; } = new Dictionary<string, Player>();
    public Player currentPlayer { get; private set; }

    public void Start()
    {
        //Client.Instance.SetPhase(Client.Phase.Action);
        CycleState();
    }

    void CycleState()
    {
        StartCoroutine(CycleStateCoroutine());
    }

    IEnumerator CycleStateCoroutine()
    {
        Client.Phase phase = Client.Phase.Wait;
        while (true)
        {
            yield return new WaitForSeconds(3f);
            switch (Client.Instance.phase)
            {
                case Client.Phase.Wait:
                    phase = Client.Phase.Action;
                    break;
                case Client.Phase.Action:
                    phase = Client.Phase.Counteraction;
                    break;
                case Client.Phase.Counteraction:
                    phase = Client.Phase.Wait;
                    break;
            }
            Client.Instance.SetPhase(phase);
        }
    }
}