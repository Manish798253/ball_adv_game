using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisiblegeneralblock: MonoBehaviour {
	GameObject go;bool yes=true;
	// Use this for initialization
	void Start () {
		go = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void FixedUpdate () {


	}
	void OnTriggerEnter2D(Collider2D other)
	{Debug.Log (other);
		if (other.gameObject.tag == "Player") {
			Debug.Log ("ball pos : " +Mathf.Floor(other.GetComponent<CircleCollider2D> ().radius + other.transform.position.y) + "and of block : " + Mathf.CeilToInt (gameObject.GetComponent<BoxCollider2D> ().bounds.min.y));
			/*if ((Mathf.FloorToInt(other.GetComponent<CircleCollider2D> ().radius + other.transform.position.y)==Mathf.CeilToInt( gameObject.GetComponent<BoxCollider2D> ().bounds.min.y)||Mathf.FloorToInt(other.GetComponent<CircleCollider2D> ().radius + other.transform.position.y)==Mathf.FloorToInt( gameObject.GetComponent<BoxCollider2D> ().bounds.min.y)) && (other.gameObject.transform.position.x >= gameObject.GetComponent<BoxCollider2D> ().bounds.min.x && other.gameObject.transform.position.x <= gameObject.GetComponent<BoxCollider2D> ().bounds.max.x)) {
				this.gameObject.GetComponent<SpriteRenderer> ().sortingLayerName = "obstacles";
				this.GetComponent<BoxCollider2D> ().isTrigger = false;

			}*/
		/*	if ((other.GetComponent<Rigidbody2D> ().velocity.normalized == Vector2.up)&&this.GetComponent<BoxCollider2D>().isTrigger==true) {
				this.gameObject.GetComponent<SpriteRenderer> ().sortingLayerName = "obstacles";
			this.GetComponent<BoxCollider2D> ().isTrigger = false;	other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.down * 200);
			}*/
		Debug.Log (other.GetComponent<BoxCollider2D> ().bounds.max.y + "," + transform.position.y);
		if ((other.gameObject.GetComponent<CircleCollider2D> ().radius + other.transform.position.x) >= (GetComponent<BoxCollider2D> ().bounds.min.x + .1f) && other.GetComponent<BoxCollider2D> ().bounds.max.y < transform.position.y&&yes==true) {
			this.gameObject.GetComponent<SpriteRenderer> ().sortingLayerName = "obstacles";yes = false;
				this.GetComponent<BoxCollider2D> ().isTrigger = false;
				other.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.down * 1000);
	
			}
		}
	}
}

