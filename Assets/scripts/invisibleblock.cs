using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisibleblock : MonoBehaviour {
	GameObject go,go1;int s=0;float sc=0,time=0;[SerializeField]private float fixtime=2;

	void Start () {
		go = GameObject.FindGameObjectWithTag ("Player");go1 = GameObject.FindGameObjectWithTag ("invisibleblock");
	}
	

	void FixedUpdate () {
		if (go1.GetComponent<BoxCollider2D> ().isTrigger == false) {
			for (int i = 0; i < go1.transform.childCount; i++)
				go1.transform.GetChild (i).GetComponent<Collider2D> ().isTrigger = false;

		}


		if (s == 1) {
			sc = go1.transform.localScale.x;time = time + Time.deltaTime;
			if (time <= fixtime)
				go1.transform.localScale = new Vector3 ((sc + 0.1f), go1.transform.localScale.y, go1.transform.localScale.z);
		}
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {			
			if ((Mathf.FloorToInt(other.GetComponent<CircleCollider2D> ().radius + other.transform.position.y)==Mathf.CeilToInt( gameObject.GetComponent<BoxCollider2D> ().bounds.min.y)||Mathf.FloorToInt(other.GetComponent<CircleCollider2D> ().radius + other.transform.position.y)==Mathf.FloorToInt( gameObject.GetComponent<BoxCollider2D> ().bounds.min.y)) && (other.gameObject.transform.position.x >= gameObject.GetComponent<BoxCollider2D> ().bounds.min.x && other.gameObject.transform.position.x <= gameObject.GetComponent<BoxCollider2D> ().bounds.max.x)) {
				this.gameObject.GetComponent<SpriteRenderer> ().sortingLayerName = "obstacles";
				this.GetComponent<Collider2D> ().isTrigger = false;
				go1.gameObject.GetComponent<SpriteRenderer> ().sortingLayerName = "obstacles";
				go1.GetComponent<Collider2D> ().isTrigger = false;s = 1;
			}
		}
	}
}
