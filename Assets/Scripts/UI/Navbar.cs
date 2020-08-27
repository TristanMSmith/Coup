using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navbar : MonoBehaviour
{
    public List<Navitem> navitems;
    public GameWindow ActionReaction, Opponents, Influences;
    public Navitem selectedNavitem { get; private set; } = null;

    public static Navbar instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("Navbar does not exist in current scene.");
            }
            return _instance;
        }
    }
    static Navbar _instance = null;

    private void Start()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Debug.LogError("Too many instances of Navbar in current scene.");
        }
    }

    public void OnClick(Navitem navitem)
    {
        Select(navitem);
    }

    public void Select(Navitem navitem)
    {
        if (selectedNavitem == null)
        {
            selectedNavitem = navitem;
            selectedNavitem.Toggle();
        }
        else if (navitem == selectedNavitem)
        {
            selectedNavitem.Toggle();
            selectedNavitem = null;
        }
        else
        {
            selectedNavitem.Toggle();
            selectedNavitem = navitem;
            selectedNavitem.Toggle();
        }
    }
}
