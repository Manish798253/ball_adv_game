using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanger : MonoBehaviour {

	void Start () {

	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.attachedRigidbody.constraints == RigidbodyConstraints2D.FreezePositionY ) {			
			other.attachedRigidbody.constraints = RigidbodyConstraints2D.None;
			other.attachedRigidbody.constraints = RigidbodyConstraints2D.FreezePositionX;
		} else if (other.attachedRigidbody.constraints == RigidbodyConstraints2D.FreezePositionX ) {			
			other.attachedRigidbody.constraints = RigidbodyConstraints2D.None;
			other.attachedRigidbody.constraints = RigidbodyConstraints2D.FreezePositionY;
		}

	}
	void OnTriggerStay2D(Collider2D o){
		if (o.gameObject.tag=="clip"&& o.gameObject.transform.position.x < GetComponent<CircleCollider2D>().bounds.min.x)
			o.gameObject.SetActive (false);
			}

}
