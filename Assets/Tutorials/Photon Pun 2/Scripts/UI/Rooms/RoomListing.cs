using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomListing : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI _text;

    public RoomInfo RoomInfo {get; private set;}
    public void SetRoomInfo(RoomInfo roomInfo)
    {
        RoomInfo = roomInfo;
        _text.text = roomInfo.MaxPlayers + ", " + roomInfo.Name;
    }
}
