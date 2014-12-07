using UnityEngine;
using System.Collections;

public class grapplingHookShoot : MonoBehaviour {

	public Transform hook; // the hook itself
	public float shootSpeed = 100f; // speed the hook SHOOTS OUT with
	public KeyCode shootButton = KeyCode.E; //made public for use by both p1 & p2

	void Update () {
		// if I press spacebar, spawn another dang cannonball
		if (Input.GetKeyDown ( shootButton ) ){
			//hook HAS TO EXIST already. we only want one. don't instantiate another (that would make no sense)
			hook.rigidbody.AddForce (transform.forward * shootSpeed);
		}
	}
}