using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bullet;
	public float force = 1000f;
	public float cooldown = 0.5f;
	float nextAvailable = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Mouse0) && Time.time >= nextAvailable) {
			GameObject clone = Instantiate (bullet, transform.position, transform.rotation) as GameObject;

			// Apply fire force
			Rigidbody rigidBody = clone.GetComponent<Rigidbody> ();
			rigidBody.AddForce(clone.transform.forward * force);

			// Play sound
			GetComponent<CardboardAudioSource> ().Play ();

			// Set cooldown
			nextAvailable = Time.time + cooldown;
		}
	}
}
