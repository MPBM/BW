using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
	GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = new Vector3 (gameObject.transform.position.x, player.transform.position.y, gameObject.transform.position.z);
	}
}
