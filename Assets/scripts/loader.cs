using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loader : MonoBehaviour {
	float s=1;[SerializeField] GameObject g1 ;[SerializeField] GameObject g2;GameObject clip;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void FixedUpdate () {
		if (g1.GetComponent<Rigidbody2D> ().velocity.y == 0 && s==1)
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
		if (gameObject.GetComponent<Rigidbody2D> ().velocity.y==0){
			for (int i = 0; i <g2.transform.childCount; i++) {

				clip = g2.transform.GetChild (i).gameObject;clip.transform.rotation = new Quaternion (0, 0, 0, 0);

								clip.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,0);	
			}

		}



	}
	void OnCollisionStay2D(Collision2D other)
	{
		s = 0;
		if (other.gameObject.tag == "Player") {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -2);
		}

	}

	void OnCollisionExit2D(Collision2D other)
	{s = 1;
		if (other.gameObject.tag == "Player")
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,0);
	}

}

