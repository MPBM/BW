using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {
	public Sprite Black;
	public Sprite White;
	SpriteRenderer mainRenderer;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			mainRenderer = gameObject.GetComponent<SpriteRenderer> ();

			if (mainRenderer.sprite == Black) {
				mainRenderer.sprite = White;
			} else {
				mainRenderer.sprite = Black;
			}

			gameObject.collider2D.enabled = !gameObject.collider2D.enabled;
		}
	}
}
