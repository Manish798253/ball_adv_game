using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emoji : MonoBehaviour {
	float time=0;
	void Start () {
		
	}
	

	void FixedUpdate () {
		time = time + Time.deltaTime;
		if (time <= 3) {
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -3);
		}
	
	if(time>=4)
		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
}
}
