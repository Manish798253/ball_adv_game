using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jadoo : MonoBehaviour {
	[SerializeField]GameObject jadoo1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}
	void OnCollisionStay2D(Collision2D other)
	{
		if (other.collider.tag != "ground" && other.gameObject.transform.position.x <= GetComponent<Collider2D>().bounds.max.x ) {
			jadoo1.gameObject.GetComponent<SpriteRenderer> ().enabled = false;jadoo1.gameObject.GetComponent<Collider2D> ().isTrigger = true;
		}
			
			


	}
	void OnCollisionExit2D(Collision2D other)
	{
		if (other.collider.tag != "ground") {
			jadoo1.gameObject.GetComponent<SpriteRenderer> ().enabled = true;jadoo1.gameObject.GetComponent<Collider2D> ().isTrigger = false;
		}


	}

}
