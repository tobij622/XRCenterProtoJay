using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camController : MonoBehaviour
{
    GameObject player;
    Vector3 offset = new Vector3(0, 0.75f, 0.1f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player == null){
            player = GameObject.FindGameObjectWithTag("Player");
            if(player == null) return;
        }
        transform.position = player.transform.position + offset;
        transform.rotation = player.transform.rotation;
        
    }
}
