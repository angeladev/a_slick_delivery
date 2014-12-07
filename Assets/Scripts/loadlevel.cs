using UnityEngine;
using System.Collections;

public class loadlevel : MonoBehaviour {
	public string level = "grippingtale";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (  Input.GetKey (KeyCode.Return) ){ //using our variable declared up top...
			Application.LoadLevel (level);
		}
	}
}
