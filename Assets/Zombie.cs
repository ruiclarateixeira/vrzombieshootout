using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.transform.LookAt(new Vector3(
			0f,
			transform.position.y,
			0f
		));
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision col)
	{
		print ("I'm Dying!!");
	}
}
