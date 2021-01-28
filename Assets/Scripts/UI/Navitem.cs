using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navitem : MonoBehaviour
{
    public enum State { Selected, Deselected }
    public State state { get; private set; } = State.Deselected;
	public GameWindow gameWindow;
	public void Toggle()
    {
        gameWindow.Toggle();
    }

    public void OnClick()
    {
        Navbar.Instance.Select(this);
    }

    public void SetText(string text)
    { 
        
    }
}