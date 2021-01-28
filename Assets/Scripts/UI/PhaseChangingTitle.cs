using System;
using UnityEngine;

public class PhaseChangingTitle : MonoBehaviour
{
    public TMPro.TextMeshProUGUI title;
    public string WaitText, ActionText, CounteractionText;
    private void Awake()
    {
        Client.Instance.PhaseChange += UpdateTitle;
        UpdateTitle(null, null);
    }
    void UpdateTitle(object sender, EventArgs e)
    {
        switch (Client.Instance.phase)
        {
            case Client.Phase.Wait:
                title.text = WaitText;
                break;
            case Client.Phase.Action:
                title.text = ActionText;
                break;
            case Client.Phase.Counteraction:
                title.text = CounteractionText;
                break;
        }
    }
}
