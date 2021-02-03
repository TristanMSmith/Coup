using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class B_Opponent : MonoBehaviour
{
    public delegate void OpponentClicked();
    public OpponentClicked OnOpponentClicked;

    public GameObject borderHighlight;
    Opponent opponent;
    public void OnClick()
    {
        //Client.Instance.opponent = opponent;
        borderHighlight.SetActive(!borderHighlight.activeSelf);
    }

    private void Awake()
    {
        borderHighlight.SetActive(false);
    }
    /*
    public void OnClick()
    {
        if (this == ActiveOpponents.Instance.selectedOpponent)
        {
            Deselect();
        }
    }
    */

}
