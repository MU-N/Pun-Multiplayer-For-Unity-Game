using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;


public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_InputField createField;
    [SerializeField] TMP_InputField joinField;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createField.text);
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinField.text);
    }
    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        PhotonNetwork.LoadLevel("Level");
    }
}
