using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Title : MonoBehaviour
{
    public TMPro.TextMeshProUGUI title;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
                title.text = "Wait";
                break;
            case Client.Phase.Action:
                title.text = "Action";
                break;
            case Client.Phase.Counteraction:
                title.text = "Counteraction";
                break;
        }
    }
}
