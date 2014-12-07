using UnityEngine;
using System.Collections;
public class cameraShake : MonoBehaviour {
	public bool Shaking;
	public Camera cam, copyCam;
	private float ShakeDecay;
	private float ShakeIntensity;
	private Vector3 OriginalPos, OriginalPosCopy;
	private Quaternion OriginalRot, OriginalRotCopy;
	public KeyCode keyPress = KeyCode.E;
	void Start()
	{
		Shaking = false;
	}
	// Update is called once per frame
	void Update ()
	{
		if(ShakeIntensity > 0)
		{
			cam.transform.position = OriginalPos + Random.insideUnitSphere * ShakeIntensity;
			cam.transform.rotation = new Quaternion(OriginalRot.x + Random.Range(-ShakeIntensity, ShakeIntensity)*.001f,
			                                    OriginalRot.y + Random.Range(-ShakeIntensity, ShakeIntensity)*.001f,
			                                    OriginalRot.z + Random.Range(-ShakeIntensity, ShakeIntensity)*.001f,
			                                    OriginalRot.w + Random.Range(-ShakeIntensity, ShakeIntensity)*.001f);
			ShakeIntensity -= ShakeDecay;
		}
		else if (Shaking)
		{
			Shaking = false;
		}

		if (Input.GetKey (keyPress) ){ //using our variable declared up top...
			//GetComponent<Rigidbody>().AddForce ( transform.forward * forwardSpeed); // in up direction, move your dang ship
			//audio.Play(); 
			DoShake();
		}
	}
	/*
	void OnCollisionEnter(Collision col)
	{
		Debug.Log("Detected collision between " + gameObject.name + " and " + col.collider.name);
		DoShake();
	}
	void OnCollisionExit(Collision col)
	{
		Debug.Log("exiting");
		OriginalPos = OriginalPosCopy;
		OriginalRot = OriginalRotCopy;
		ShakeIntensity = 0;
		ShakeDecay = 0;
		Shaking = false;
	}
	*/
	public void DoShake()
	{
		cam = Camera.main.GetComponent<Camera>();
		copyCam = Camera.main.GetComponent<Camera>();
		OriginalPosCopy = copyCam.transform.position;
		OriginalRotCopy = copyCam.transform.rotation;
		OriginalPos = cam.transform.position;
		OriginalRot = cam.transform.rotation;
		ShakeIntensity = 0.05f;
		ShakeDecay = 0.015f;
		Shaking = true;
	}
}
