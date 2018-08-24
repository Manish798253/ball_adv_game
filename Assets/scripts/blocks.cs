using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocks : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
	/*	if (other.gameObject.tag == "Player" &&transform.position.y >other.gameObject.transform.position.y&&gameObject.transform.position.x>=transform.position.x) {
			other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.down * 200);
		}*/
	}
}
