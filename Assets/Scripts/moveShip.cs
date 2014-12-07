using UnityEngine;
using System.Collections;

public class moveShip : MonoBehaviour {
	//using public variables for keys so we can swap these out for multiple players 
	public KeyCode keyForward = KeyCode.W;
	public KeyCode keyBackward = KeyCode.S;
	public KeyCode keyLeft = KeyCode.A;
	public KeyCode keyRight = KeyCode.D;

	public float turnSpeed = 5f;
	public float forwardSpeed = 10f;

	//public AudioClip moveSound; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*
		Things to ensure on the ship itself (in Unity, not in the code)
			- Object is locked on the Y axis, so it cannot move up/down
			- Object can only rotate along its Y axis (so, when you turn it, it doesn't do barrel rolls or back flips etc though that would be really cool)
		 */
		//audio.clip = moveSound;
		if (  Input.GetKey (keyForward) ){ //using our variable declared up top...
			GetComponent<Rigidbody>().AddForce ( transform.forward * forwardSpeed); // in up direction, move your dang ship
			//audio.Play(); 
		}

		if (  Input.GetKey (keyBackward) ){ //using our variable declared up top...
			GetComponent<Rigidbody>().AddForce ( transform.forward * -forwardSpeed); // in up direction, move your dang ship
		}
		if (Input.GetKey (keyLeft) ) {//turn left
			GetComponent<Rigidbody>().AddTorque (  0f, -turnSpeed, 0f);		
		}
		if (Input.GetKey (keyRight) ) {//turn left
			GetComponent<Rigidbody>().AddTorque ( 0f, turnSpeed, 0f  );		
		}		
	}
}
