using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyactor : MonoBehaviour {
	[ SerializeField ] private ballActor Ballactor;[SerializeField] private cameraActor Cam;public static Rigidbody2D rigidbody2d,r;
	// Use this for initialization
	float x;

	void Start () {
		rigidbody2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Debug.Log ("baal "+Mathf.FloorToInt( Ballactor.GetComponent<BoxCollider2D> ().bounds.max.x)+","+ Mathf.FloorToInt(gameObject.GetComponent<BoxCollider2D>().bounds.min.x));
		if (((Mathf.FloorToInt(Mathf.FloorToInt (gameObject.GetComponent<BoxCollider2D>().bounds.min.x) - Mathf.FloorToInt (Ballactor.GetComponent<BoxCollider2D>().bounds.max.x) )== 0) || Mathf.FloorToInt(Mathf.FloorToInt (gameObject.GetComponent<BoxCollider2D>().bounds.max.x) - Mathf.FloorToInt (Ballactor.GetComponent<BoxCollider2D>().bounds.min.x) )== 0)&& (Mathf.FloorToInt(frndotherthancoin.max())-Mathf.FloorToInt(Ballactor.GetComponent<CircleCollider2D>().bounds.min.y))<=0)  {


			if (x == 0)
				rigidbody2d.bodyType = RigidbodyType2D.Dynamic;
			x++;
		}

	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if (Mathf.Floor (rigidbody2d.velocity.y) == 0) {
			rigidbody2d.bodyType = RigidbodyType2D.Kinematic;rigidbody2d.velocity.Set (0, 0);
		}

	}


}

