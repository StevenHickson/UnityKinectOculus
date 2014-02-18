using UnityEngine;
using System.Collections;

public class Fireball : MonoBehaviour {
	
	public Rigidbody Projectile;
	public GameObject HandPosition;
	
	private Vector3 lastPos;
	private float THRESH, MAX_THRESH, SPEED;
	// Use this for initialization
	void Start () {
		lastPos = HandPosition.transform.position;
		THRESH = 0.11f;
		MAX_THRESH = 0.4f;
		SPEED = 3;
	}
	
	// Update is called once per frame
	void Update () {
		float dist = (HandPosition.transform.position - lastPos).magnitude;
		print ("Distance: " + dist);
		if (Input.GetButtonDown("Fire1") || (dist > THRESH && dist < MAX_THRESH)) {
            Rigidbody clone;
            clone = (Rigidbody)Instantiate(Projectile, HandPosition.transform.position, HandPosition.transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.forward * SPEED);
        }
		
		lastPos = HandPosition.transform.position;
		
	}
}
