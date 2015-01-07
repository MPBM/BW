using UnityEngine;
using System.Collections;

public class Floors : MonoBehaviour {
	public Sprite Black;
	public Sprite White;
	BoxCollider2D[] floorsCollider;

	// Use this for initialization
	void Start () {
		floorsCollider = gameObject.GetComponentsInChildren<BoxCollider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void triggerOff(){
		for (var i = 0; i < floorsCollider.Length; i++) {
			floorsCollider [i].isTrigger = false;
		}
	}
}
