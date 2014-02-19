using UnityEngine;
using System.Collections;

public class Fireball : MonoBehaviour {
	
	public Rigidbody Projectile;
	public GameObject HandPosition;
	public GameObject HipPosition;
	
	private Vector3 lastPos;
	private static int THRESH, MAX_THRESH;
	private static float SPEED;
	// Use this for initialization
	void Start () {
		lastPos = HandPosition.transform.position;
		THRESH = 4;
		MAX_THRESH = 13;
		SPEED = 2.5f;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 norm_hand = HandPosition.transform.position - HipPosition.transform.position;
		Vector3 velocity = (norm_hand - lastPos) / Time.deltaTime;
		float dist = velocity.magnitude;
//		if(dist > 0.5)
//			print ("Velocity: " + dist);
		if (Input.GetButtonDown("Fire1") || (dist > THRESH && dist < MAX_THRESH)) {
            Rigidbody clone;
			Vector3 pos = HandPosition.transform.position;
			pos.z += 1;
            clone = (Rigidbody)Instantiate(Projectile, pos, transform.rotation);
            //clone.velocity = transform.TransformDirection(Vector3.forward * SPEED);
			clone.velocity = velocity * SPEED;
        }
		
		lastPos = norm_hand;
		
	}
	
	private void OnCollisionEnter(Collision collision) {
		Destroy(this);
	}
	
	private void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
	}
}
