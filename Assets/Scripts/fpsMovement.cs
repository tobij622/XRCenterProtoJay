using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class fpsMovement : MonoBehaviour
{
    Rigidbody rb;

    public TextMesh playerName;

    Color newColor;
     Vector2 currentMouseLook;
    Vector2 appliedMouseDelta;
    public float sensitivity = 1;
    public float smoothing = 2;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        if(this.tag != "Player") return;

        if(Input.GetKey(KeyCode.W)){
           rb.AddForce(transform.forward * 20); 
        }
        
        else if(Input.GetKey(KeyCode.S)){
           rb.AddForce(transform.forward * -20); 
        }

        if(Input.GetKey(KeyCode.A)){
            rb.AddForce(transform.right * -20);
        }

        else if(Input.GetKey(KeyCode.D)){
            rb.AddForce(transform.right * 20);
        }

        if(Input.GetKey(KeyCode.E)){
            rb.AddTorque(transform.up * 0.4f);
        }

        if(Input.GetKey(KeyCode.Q)){
            rb.AddTorque(transform.up * -0.4f);
        }

    }
}
