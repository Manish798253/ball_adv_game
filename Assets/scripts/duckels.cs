using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duckels : MonoBehaviour {
	[SerializeField]Sprite newspriteforduckel;Sprite oldone;float velocity=-6f;int s=0;float vel;

	void Start () {
		oldone = GetComponent<SpriteRenderer> ().sprite;
	}
	

	void FixedUpdate () {
		if (GetComponent<SpriteRenderer> ().sprite == oldone) {
			s = 1;
		} else {
			
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
		}
		if(s==1)
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (velocity, 0);
		vel = Mathf.Abs( GetComponent<Rigidbody2D> ().velocity.x);
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player") {
			
			if (other.transform.position.y < (GetComponent<BoxCollider2D> ().bounds.max.y+.3f) &&(Mathf.Abs( vel) >0))
				other.gameObject.SetActive (false);
			else if (gameObject.GetComponent<SpriteRenderer> ().sprite == oldone) {
				gameObject.GetComponent<SpriteRenderer> ().sprite = newspriteforduckel;
				s = 0;
			} else if (Mathf.Abs( gameObject.GetComponent<Rigidbody2D> ().velocity.x) <3f) {
				s = 1;
				if (other.transform.position.x < GetComponent<BoxCollider2D> ().bounds.center.x)
					velocity = 2 * 4f;
				else
					velocity = 2 * -4f;
				
			} else
				s = 0;
		} else if (other.gameObject.tag != "ground") {
			velocity = -velocity;
			if (GetComponent<SpriteRenderer> ().flipX == false)
				GetComponent<SpriteRenderer> ().flipX = true;
			else
				GetComponent<SpriteRenderer> ().flipX = false;
		}

	}
}
