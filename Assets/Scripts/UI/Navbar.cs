using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navbar : Singleton<Navbar>
{
    public List<Navitem> navitems;
    public GameWindow ActionReaction, Opponents, Influences;
    public Navitem selectedNavitem { get; private set; } = null;

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
