using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsWithMouse : MonoBehaviour
{
	Vector2 rotation = new Vector2 (0, 0);
	public float speed = 3;

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

		rotation.y += Input.GetAxis ("Mouse X");
		rotation.x += -Input.GetAxis ("Mouse Y");
		transform.eulerAngles = (Vector2)rotation * speed;

    }
}
