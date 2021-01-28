using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class B_Opponent : MonoBehaviour
{
    public GameObject borderHighlight;
    Opponent opponent;
    public void OnClick()
    {
        Client.Instance.opponent = opponent;
    }

    private void Start()
    {
        borderHighlight.SetActive(false);
    }

}
