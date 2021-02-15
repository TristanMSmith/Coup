using Photon.Realtime;
using Photon.Pun;
using UnityEngine;

public class CreateRoomMenu : MonoBehaviourPunCallbacks
{
	[SerializeField]
	private TMPro.TextMeshProUGUI _roomName;
	
	public void OnClick_CreateRoom()
	{
		if (!PhotonNetwork.IsConnected || _roomName.text == null || _roomName.text == string.Empty)
		{
			return;
		}

		//validate that _roomName is not null before creating the room
		RoomOptions options = new RoomOptions();
		options.MaxPlayers = 6;
		options.PlayerTtl = 300000;//5 minutes
		options.EmptyRoomTtl = 300000;//5 minutes
		PhotonNetwork.JoinOrCreateRoom(_roomName.text, options, TypedLobby.Default);
	}

	public override void OnCreatedRoom()
	{
		Debug.Log("Created room successfully.");
	}

	public override void OnCreateRoomFailed(short returnCode, string message)
	{
		Debug.Log("Room creation failed: " + message);
	}
}
