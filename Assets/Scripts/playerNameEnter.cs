using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;


public class playerNameEnter : MonoBehaviour
{

    public InputField nametf;
    public Button setNameBtn;

    public void OnTFChange(string value){
        if(value.Length > 1){
            setNameBtn.interactable = true; 
        }
    }

    public void OnClick_SetName(){
        PhotonNetwork.NickName = nametf.text;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
