using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _moveMe : MonoBehaviour {
    
    Animator myAnime;
    float Pspeed = 2.0f;

	void Start ()
    {
        myAnime = GetComponent<Animator>();
		
	}
	

	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) ||Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.D))
        {
            myAnime.SetBool("isWalking",true);
            myAnime.SetBool("isIdle", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            myAnime.SetTrigger("isRunning");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnime.SetTrigger("isHitting");
        }
   

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            myAnime.SetBool("isWalking", false);  
            myAnime.SetBool("isIdle", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            myAnime.SetTrigger("isIdlee");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myAnime.SetTrigger("isIdlee");
        }
      
	}

     void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.LeftShift)))
        {
            transform.position += Vector3.forward * Time.deltaTime * Pspeed;
            transform.GetComponent<Rigidbody>().rotation = Quaternion.LookRotation(Vector3.forward);
 
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime * Pspeed;
            transform.GetComponent<Rigidbody>().rotation = Quaternion.LookRotation(Vector3.back);


        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * Pspeed;
            transform.GetComponent<Rigidbody>().rotation = Quaternion.LookRotation(Vector3.left);


        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * Pspeed;
            transform.GetComponent<Rigidbody>().rotation = Quaternion.LookRotation(Vector3.right);


        }
    }
}
