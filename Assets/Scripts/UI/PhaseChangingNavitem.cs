using System;

public class PhaseChangingNavitem : Navitem
{
    public TMPro.TextMeshProUGUI text;
	public string WaitText, ActionText, CounteractionText;
    private void Awake()
    {
        Client.Instance.PhaseChange += UpdateNavItem;
        UpdateNavItem(null, null);
    }
    void UpdateNavItem(object sender, EventArgs e)
    {
        switch (Client.Instance.phase)
        {
            case Client.Phase.Wait:
                text.text = WaitText;
                break;
            case Client.Phase.Action:
                text.text = ActionText;
                break;
            case Client.Phase.Counteraction:
                text.text = CounteractionText;
                break;
        }
    }
}
