using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Zombie : MonoBehaviour {
	public float zombieStep = 0.01f;
	private Vector3 origin;

	// Use this for initialization
	void Start () {
		origin = new Vector3 (0f, transform.position.y, 0f);
		gameObject.transform.LookAt(origin);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, origin, zombieStep);

		if (transform.position == origin) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}
}
