using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class coinactor : MonoBehaviour {
	Vector3 r,diff;GameObject ballact;[SerializeField]private magnet mag;[SerializeField] private float vel;[SerializeField]public AudioSource coinvoice;
	[SerializeField]AudioClip au;

	void Start () {
		ballact = GameObject.FindGameObjectWithTag ("Player");
		gameObject.AddComponent<Rigidbody2D> ();gameObject.GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Dynamic;
		gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0;
	}
	

	void FixedUpdate () {
		if(gameObject.tag=="going") {
			r = ballact.transform.position;
			diff = r - transform.position;
			gameObject.GetComponent<Rigidbody2D> ().velocity = vel * diff.normalized;
		}
	}
	void OnTriggerEnter2D(Collider2D  other)
	{ 
		if (other.gameObject.tag == "Player") {
			coinvoice.PlayOneShot (au, 1);
		
			Destroy (this.gameObject);
		}
		
}
}