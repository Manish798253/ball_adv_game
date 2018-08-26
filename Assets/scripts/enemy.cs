using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
	Rigidbody2D rb;float s = -2f;bool yes=false;int d=0;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	

	void FixedUpdate () {
		
		transform.rotation = new Quaternion (0, 0, 0, 0);
		if (d == 0) {
			rb.velocity = new Vector2 (s,0);
		}
	}
	void OnCollisionEnter2D(Collision2D other)
	{   
		if (other.gameObject.tag== "Player") {
			Destroy (gameObject);
		}
		else if((other.gameObject.tag!="ground")&&(other.gameObject.transform.parent!=null&&other.gameObject.transform.parent.tag!="ground")){
			yes = !yes;
			gameObject.GetComponent<SpriteRenderer> ().flipX = yes;s = -s;d = 0;
		}

	}
	void OnTriggerStay2D(Collider2D other)
	{    if (other.gameObject.tag == "Player") {
			other.gameObject.SetActive (false);
		}
		if (other.gameObject.tag == "bullet") {
			Destroy (this.gameObject);Destroy (other.gameObject);
		}
	}
	void OnCollisionExit2D(Collision2D other)
	{
		d = 1;rb.velocity = new Vector2 (0, -4f);
	}
	void OnCollisionStay2D(Collision2D other)
	{
		d = 0;
	}
		

}
