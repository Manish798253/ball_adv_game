using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vivsible_or_not : MonoBehaviour {
	float time;
	// Use this for initialization
	void Start () {
		
		GetComponent<Rigidbody2D> ().isKinematic = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (GetComponent<Collider2D> ().isTrigger == false) {
			time = Time.deltaTime + time;
			if(time>=1)
			GetComponent<Rigidbody2D> ().isKinematic = false;
		}
	}
	void OnCollisionStay2D(Collision2D other)
	{
		if (other.gameObject.tag == "clue" && gameObject.transform.position.x+2f>=other.transform.position.x ) {
			other.gameObject.GetComponent<SpriteRenderer> ().enabled = false;other.gameObject.GetComponent<Collider2D> ().isTrigger = true;
			gameObject.SetActive (false);
		}
	}
}
