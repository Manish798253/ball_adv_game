using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class again_visible_block : MonoBehaviour {



	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player" && other.transform.position.y<=transform.position.y) {
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			GetComponent<Collider2D> ().isTrigger = false;
		}

	}
}
