using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class B_Interaction : MonoBehaviour
{
    public Interaction interaction;

    public void OnClick()
    {
        InteractionEvent();
    }

    void InteractionEvent()//set this up as an event that fires off. The GameController class will listen for this event.
    { 
        
    }

    private void Awake()
    {
        if (interaction == null)
        {
            Debug.LogError("Interaction not bound for " + name + ". Disabling " + name + ".");
            enabled = false;
            return;
        }
        GetComponent<Image>().sprite = interaction.sprite;
        GetComponentInChildren<TextMeshProUGUI>().SetText(interaction.name);
        Client.instance.PhaseChange += UpdateVisibility;
        UpdateVisibility(null, null);
    }

    void UpdateVisibility(object sender, EventArgs e)
    {
        switch (Client.instance.phase)
        {
            case Client.Phase.Wait:
                break;
            case Client.Phase.Action:
                break;
            case Client.Phase.Counteraction:
                break;
        }
    }

}
