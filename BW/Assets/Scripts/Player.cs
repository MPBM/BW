using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	Vector3 speed = new Vector3(0.05f,0,0);
	public bool canChange = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += speed;

		if (Input.GetMouseButtonDown (0) && canChange) {
			speed = -speed;
			canChange = false;
		}
	}

	void OnCollisionEnter2D(Collision2D obj){
		if (obj.collider.tag == "Floor") {
			canChange = true;
		}

		if (obj.collider.tag == "Wall") {
			Debug.Log ("Game Over");
			speed = -speed;
		}
	}
}
