using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class again_visible_block : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void FixedUpdate () {
		
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player" && other.transform.position.y<=transform.position.y) {
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			GetComponent<Collider2D> ().isTrigger = false;
		}

	}
}
