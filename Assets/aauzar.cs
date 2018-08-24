using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aauzar : MonoBehaviour {
	Rigidbody2D rb;public GameObject go;int f = 0;float x;monkeyactor monkey;float a;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();  a = Random.Range (1, 8);
		this.x =a;
		 
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(go.GetComponent<SpriteRenderer>().flipX==false && f==0)
			rb.velocity = new Vector2 (-x, 2f);
		if(go.GetComponent<SpriteRenderer>().flipX==true && f==0)
			rb.velocity = new Vector2 (x, 2f);

		f++;
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.transform.parent != null && other.transform.parent.tag == "ground")
			Destroy (gameObject);
		else if (other.gameObject.tag == "Player"||other.gameObject.tag=="Player2")
			other.gameObject.SetActive (false);
	}
}
