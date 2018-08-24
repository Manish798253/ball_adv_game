using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletfiring1 : MonoBehaviour {
	float time;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		time = time + Time.deltaTime;
		if (time >= 3f) {gameObject.SetActive (false);
			Destroy (gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D other)
	{ Debug.Log (other.collider.tag);
		if (other.collider.tag == "spider") {
			other.gameObject.SetActive (false);
			gameObject.SetActive (false);
			Destroy (gameObject);
		}


	}
}
