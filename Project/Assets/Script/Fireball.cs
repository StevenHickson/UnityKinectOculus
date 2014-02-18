using UnityEngine;
using System.Collections;

public class Fireball : MonoBehaviour {
	
	public Rigidbody Projectile;
	public GameObject HandPosition;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
            Rigidbody clone;
            clone = (Rigidbody)Instantiate(Projectile, HandPosition.transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.forward * 10);
        }
	}
}
