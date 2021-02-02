using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B_Influence : MonoBehaviour
{
    public Influence influence;
    public Animator animator;
    public Image influenctIcon;
    public TMPro.TextMeshProUGUI influenceName, influenceDescription;
    // Start is called before the first frame update
    void Start()
    {
        //influenctIcon.sprite = influence.sprite;
        influenceName.text = influence.name;
        influenceDescription.text = influence.description[0];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Toggle();
    }
    void Toggle()
    {
        animator.SetBool("isCollapsed", !animator.GetBool("isCollapsed"));
    }  
}
