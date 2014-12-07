using UnityEngine;
using System.Collections;

public class polarBearCollider : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter ( Collision thing){
		if (thing.transform.name == ("Player 1 Hat") ){
			print ("bah blahsdfas");
			Application.LoadLevel ("gripping_tale_win_2");
		}
		if(thing.transform.name == ("Player 2 Hat")){
			print ("badasdass");
			Application.LoadLevel ("gripping_tale_win_1");
		}
	} 
}
