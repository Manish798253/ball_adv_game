using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clip_movement : MonoBehaviour {
	[SerializeField] GameObject go1,go2 ,other,o;float vel;GameObject g;
	void Start () {

	}


	void FixedUpdate () {
		vel = 2;



		if (go1.GetComponent<Rigidbody2D> ().velocity.y < 0) {
			vel = -vel;
			g = go2;
			movement ();	
		} else if (go2.GetComponent<Rigidbody2D> ().velocity.y < 0) {
			vel = vel;
			g = go1;
			movement ();
		} else if (go1.GetComponent<Rigidbody2D> ().velocity.y == 0) {
			vel = 0;
			g = null;
			movement ();
		}

	}

	void movement ()
	{
		for (int i = 0; i < transform.childCount; i++) {

			other = transform.GetChild (i).gameObject;
			other.transform.rotation = new Quaternion (0, 0, 0, 0);
			if (other.GetComponent<Rigidbody2D> ().constraints == RigidbodyConstraints2D.FreezePositionY) {
				other.transform.position = new Vector2 (other.transform.position.x,7.328038f);
				other.GetComponent<Rigidbody2D> ().velocity = new Vector2 (vel, 0);
			}
			if (other.GetComponent<Rigidbody2D> ().constraints == RigidbodyConstraints2D.FreezePositionX) {
				if (go1.GetComponent<Rigidbody2D> ().velocity.y < 0) {
					if (o.transform.position.x > other.transform.position.x) {
						other.transform.position = new Vector2 (121.8225f, other.transform.position.y);
						other.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, vel);
					} else {
						other.transform.position = new Vector2 (127.0825f, other.transform.position.y);
						other.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -vel);
					}

				} else if (go2.GetComponent<Rigidbody2D> ().velocity.y < 0) {
					if (o.transform.position.x > other.transform.position.x) {
						other.transform.position = new Vector2 (121.8225f, other.transform.position.y);
						other.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, vel);
					} else {
						other.transform.position = new Vector2 (127.0825f, other.transform.position.y);
						other.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -vel);
					}

				}
				else
					other.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, vel);
			}
		}

	}
}





