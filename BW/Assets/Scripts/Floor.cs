using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {
	public Sprite Black;
	public Sprite White;
	SpriteRenderer mainRenderer;
	GameObject[] floors;

	// Use this for initialization
	void Start () {
		floors = GameObject.FindGameObjectsWithTag("Floor");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			mainRenderer = gameObject.GetComponent<SpriteRenderer> ();

			if (mainRenderer.sprite == Black) {
				mainRenderer.sprite = White;
				gameObject.collider2D.enabled = false;
			} else {
				mainRenderer.sprite = Black;
				gameObject.collider2D.enabled = true;
				gameObject.collider2D.isTrigger = true;
			}
				
		}
	}

	void OnTriggerExit2D(Collider2D obj){
		for (var i = 0; i < floors.Length; i++) {
			floors [i].collider2D.isTrigger = false;
		}
	}
}
