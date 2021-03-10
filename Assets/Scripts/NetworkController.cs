using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using Photon.Realtime;

public class NetworkController : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Connecting...");
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster(){
        Debug.Log("Connected! Joining room...");

        var roomOptions = new RoomOptions();
        roomOptions.IsOpen = true;
        roomOptions.IsVisible = true;
        roomOptions.MaxPlayers = 20;

        PhotonNetwork.JoinOrCreateRoom("test", roomOptions, TypedLobby.Default);
    }

    public override void OnJoinedRoom(){
        Debug.Log("Joined room!");
        RespawnPlayer();
    }

    public void RespawnPlayer(){
        Debug.Log("Spawning player...");

        var respawnPoints = GameObject.FindGameObjectsWithTag("Respawn");
        var respawn = respawnPoints[Random.Range(0, respawnPoints.Length)];

        var player = PhotonNetwork.Instantiate("Player", respawn.transform.position, respawn.transform.rotation);
        player.tag = "Player";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
