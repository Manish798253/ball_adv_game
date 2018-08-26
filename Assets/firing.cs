using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firing : MonoBehaviour {
	GameObject ballact;[SerializeField] float velocity;float vel;int s=0; GameObject dead;

	void Start () {
		ballact = GameObject.FindGameObjectWithTag ("Player");dead = GameObject.FindGameObjectWithTag ("deadlyenemy");
	}

	void FixedUpdate () {
		
		vel = velocity;
		if (s == 0) {
			if (ballact.GetComponent<Rigidbody2D> ().velocity.x < 0) {
				vel = -velocity;
				gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (vel, 0);
				s = 1;
			} else {
				vel = velocity;
				gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (vel, 0);
				s = 1;
			}
		}
		if (((transform.position.x - ballact.transform.position.x >= 8)&&gameObject.GetComponent<Rigidbody2D>().velocity.x>0)||((transform.position.x-ballact.transform.position.x<=-8)&&gameObject.GetComponent<Rigidbody2D>().velocity.x<0))
			Destroy (this.gameObject);
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "pak" &&other.gameObject.GetComponent<Collider2D>().isTrigger==false) {
			Destroy (other.gameObject);
			Destroy (this.gameObject);
		}
		if (other.gameObject.tag == "deadlyenemy" && other.gameObject.transform.position.x< 2+ transform.position.x) {			
			dead.GetComponent<deadlyenemy> ().count++;
		}

			
}
}
