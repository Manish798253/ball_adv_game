using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {
	float time=0;

	void FixedUpdate () {

		time = time + Time.deltaTime;
		if (time <= 1)
			GetComponent<Rigidbody2D> ().velocity = Vector2.down * 50;
		else {
			time = 0;
			Destroy (this.gameObject);

		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			other.gameObject.SetActive (false);

		}
	}
}
