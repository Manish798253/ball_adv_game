using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour {
	[SerializeField] GameObject ball;float s=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (s == 1 && ball!=null) {
			transform.position = ball.transform.position;
		}
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player"||other.tag=="Player2") {
			GetComponent<SpriteRenderer> ().enabled = false;ball = other.gameObject;
			s = 1;

		}
	}

}
