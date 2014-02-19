using UnityEngine;
using System.Collections;

public class DestroyFireball : MonoBehaviour {
	
	private int counter;
	private static int TOTAL;
	// Use this for initialization
	void Start () {
		counter = 0;
		TOTAL = 10;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	private void OnCollisionEnter(Collision collision) {
		if(counter >= TOTAL)
			Destroy(gameObject);
		else
			counter++;
	}
	
	private void OnCollisionStay(Collision collision) {
		if(counter >= TOTAL)
			Destroy(gameObject);
		else
			counter++;
	}
}
