using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisiblegeneralblock: MonoBehaviour {
	GameObject go;bool yes=true;

	void Start () {
		go = GameObject.FindGameObjectWithTag ("Player");
	}


	void FixedUpdate () {


	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			
		
		if ((other.gameObject.GetComponent<CircleCollider2D> ().radius + other.transform.position.x) >= (GetComponent<BoxCollider2D> ().bounds.min.x + .1f) && other.GetComponent<BoxCollider2D> ().bounds.max.y < transform.position.y&&yes==true) {
			this.gameObject.GetComponent<SpriteRenderer> ().sortingLayerName = "obstacles";yes = false;
				this.GetComponent<BoxCollider2D> ().isTrigger = false;
				other.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.down * 1000);
	
			}
		}
	}
}

