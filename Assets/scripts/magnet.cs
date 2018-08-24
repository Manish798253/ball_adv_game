using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnet : MonoBehaviour {
	public float m = 0,s=0;GameObject go,going;float time=0;[SerializeField]private float t;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (s == 1) {
			gameObject.GetComponent<Rigidbody2D> ().velocity = go.GetComponent<Rigidbody2D> ().velocity;
			time = time + Time.deltaTime;

		}

		if (time >= t)
			Destroy (gameObject);
		
	}
	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player" && (-other.gameObject.transform.position.x + transform.position.x <= 1f)&&(-other.gameObject.transform.position.y + transform.position.y <= 1f)&&(-other.gameObject.transform.position.y + transform.position.y >= -1f)&&(-other.gameObject.transform.position.x + transform.position.x >= -1f)) {
			s = 1;go = other.gameObject;gameObject.GetComponent<SpriteRenderer> ().enabled = false;

		}
		if (other.gameObject.tag == "friend" && s==1)
			other.gameObject.tag = "going";
	}
}
