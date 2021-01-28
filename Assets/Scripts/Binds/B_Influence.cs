using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Influence : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
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
