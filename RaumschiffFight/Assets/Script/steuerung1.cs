
using UnityEngine;
using System.Collections;
using System.Collections.Generic
 


public class steuerung1 : MonoBehaviour {

    public float speed = 5;
    Rigidbody2D rb; 

	void Start () {

        rb = GetComponent<Rigidbody2D>();
		
	}

     void FixedUpdate()
    {
        rb.AddForce(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")), ForceMode2D.Force);
    }

   
    
		
	}

