using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanger : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}


	void OnTriggerEnter2D(Collider2D other)
	{Debug.Log ("yes");
		/*if (other.attachedRigidbody.velocity.x != 0) {
			velocity (other.gameObject, 0, -Mathf.Abs( other.attachedRigidbody.velocity.x));
		}
		if (other.attachedRigidbody.velocity.y != 0) {
			velocity (other.gameObject, 0, -Mathf.Abs( other.attachedRigidbody.velocity.x));
		}*/
		//if((other.gameObject.GetComponent<BoxCollider2D>().bounds.max.y>=transform.position.y)&&( other.gameObject.GetComponent<BoxCollider2D>().bounds.max.x<=transform.position.x))
		if (other.attachedRigidbody.constraints == RigidbodyConstraints2D.FreezePositionY ) {
			Debug.Log (" initially freezed along y"); 
			other.attachedRigidbody.constraints = RigidbodyConstraints2D.None;
			other.attachedRigidbody.constraints = RigidbodyConstraints2D.FreezePositionX;
			Debug.Log (other.attachedRigidbody.constraints);
			//other.attachedRigidbody.constraints = RigidbodyConstraints2D.fre
		} else if (other.attachedRigidbody.constraints == RigidbodyConstraints2D.FreezePositionX ) {
			Debug.Log (" initially freezed along x"); 
			other.attachedRigidbody.constraints = RigidbodyConstraints2D.None;
			other.attachedRigidbody.constraints = RigidbodyConstraints2D.FreezePositionY;
			Debug.Log (other.attachedRigidbody.constraints);
			//other.attachedRigidbody.constraints = RigidbodyConstraints2D.fre
		}

	}
	void OnTriggerStay2D(Collider2D o){
		if (o.gameObject.tag=="clip"&& o.gameObject.transform.position.x < GetComponent<CircleCollider2D>().bounds.min.x)
			o.gameObject.SetActive (false);
			}
	/*void OnTriggerExit(Collider2D other)
	{
		other.gameObject.SetActive (false);
	}*/


	/*	void   velocity(GameObject go, float velocity_x,float velocity_y )
	{
					go.GetComponent<Rigidbody2D> ().velocity=new Vector2 (velocity_x, velocity_y);
	}*/
}
