using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suspension : MonoBehaviour {
	[SerializeField]private float force;float s=0;

	void Start () {
		
	}
	

	void FixedUpdate () {
		
	}
	void OnCollisionExit2D(Collision2D other)
	{ s = 0;
		if (other.gameObject.tag == "Player")
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
	}

}
