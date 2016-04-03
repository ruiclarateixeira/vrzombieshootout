using UnityEngine;
using System.Collections;

public class Growl : MonoBehaviour {

	public float cooldown = 5f;
	float nextGrowl = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= nextGrowl) {
			GetComponent<CardboardAudioSource> ().Play ();
			nextGrowl = Time.time + cooldown;
		}
	}
}
