using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : Singleton<Controller>
{

    public Dictionary<string, Player> players { get; private set; } = new Dictionary<string, Player>();
    public Player currentPlayer { get; private set; }

    public void Start()
    {
        //StartCoroutine(CycleState());
        Client.Instance.Action();
    }

    IEnumerator CycleState()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            switch (Client.Instance.phase)
            {
                case Client.Phase.Wait:
                    Client.Instance.Action();
                    break;
                case Client.Phase.Action:
                    Client.Instance.Counteraction();
                    break;
                case Client.Phase.Counteraction:
                    Client.Instance.Wait();
                    break;
            }
        }
    }
}