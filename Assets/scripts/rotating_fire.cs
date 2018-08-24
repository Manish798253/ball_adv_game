using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotating_fire : MonoBehaviour {
	public referralsoforfire referral;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Rotate (new Vector3 (0, 0,referral.rotatingvalue ));
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
			other.gameObject.SetActive (false);
	}
}
