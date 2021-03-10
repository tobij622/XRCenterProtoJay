using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class nameTextHandler : MonoBehaviour
{

    public PhotonView photonView;
    public TextMesh textObject;

    public Button setNameBtn;

    public InputField nameField;
    // Start is called before the first frame update
    void Start()
    {
     setNameBtn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick(){
        PhotonNetwork.LocalPlayer.NickName = nameField.text;
 
    }

    // Update is called once per frame
    void Update()
    {
        if(photonView.IsMine){
        textObject.text =  PhotonNetwork.LocalPlayer.NickName;
        }
        else textObject.text = photonView.Owner.NickName;
    }
    
}
