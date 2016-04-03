using UnityEngine;
using System.Collections;

public class ZombieSpawn : MonoBehaviour {
	public GameObject zombie;
	public float initialCooldown = 1f;
	float currentCooldown;
	float nextSpawn;

	// Use this for initialization
	void Start () {
		currentCooldown = initialCooldown;
		nextSpawn = Time.time + currentCooldown;
		spawn ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= nextSpawn) {
			spawn ();
			nextSpawn = Time.time + currentCooldown;
			currentCooldown = currentCooldown <= 0 ? currentCooldown : currentCooldown - 0.1f;
		}
	}

	void spawn() {
		Vector3 newPosition;
		do { 
			newPosition = new Vector3 (
				Random.Range (-20f, 20f),
				0.0f,
				Random.Range (-20f, 20f)
			);
		}
		while((newPosition.x < 2f && newPosition.x > -2f) || (newPosition.z < 2f && newPosition.z > -2f));

		Instantiate (zombie, newPosition, transform.rotation);
	}
}
