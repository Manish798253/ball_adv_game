using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointededge : MonoBehaviour {
	GameObject ballact;float s,f=0,inity;
	// Use this for initialization
	void Start () {
		ballact = GameObject.FindGameObjectWithTag ("Player");inity = transform.position.y;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (ballact.GetComponent<BoxCollider2D> ().bounds.max.x >= transform.position.x) {
			f = 1;
		}
		if ((transform.position.y-inity<=3)&& (f==1)) {
			transform.position = new Vector3 (transform.position.x, transform.position.y+ s, transform.position.z);s = 0.3f;
			}

		
		}



	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
			other.gameObject.SetActive (false);

	}
}
