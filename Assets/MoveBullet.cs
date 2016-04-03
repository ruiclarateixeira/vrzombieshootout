using UnityEngine;
using System.Collections;

public class MoveBullet : MonoBehaviour {

	private Vector3 prevPos;

	// Use this for initialization
	void Start () {
		prevPos = transform.position;
	}

	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if(Physics.Linecast(prevPos, transform.position, out hit))
		{
			Destroy (hit.transform.gameObject);
			Destroy (gameObject);
		}
		prevPos = transform.position;

		if (this.transform.position.y <= 0f) {
			Destroy (gameObject);
		}
	}
}