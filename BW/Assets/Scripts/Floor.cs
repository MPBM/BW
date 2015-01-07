using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {
	public Sprite Black;
	public Sprite White;
	SpriteRenderer mainRenderer;
	Player player;
	Floors floors;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player").GetComponent<Player>();
		floors = GameObject.Find ("Floors").GetComponent<Floors>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && player.canChange) {
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
		floors.triggerOff ();
	}
}
