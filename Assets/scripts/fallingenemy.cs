using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingenemy : MonoBehaviour {
	Vector3 t;
	private Rigidbody2D rb;float s;[SerializeField] private float vel;
	private GameObject camact;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();camact = GameObject.FindGameObjectWithTag ("MainCamera");
	}

	// Update is called once per frame
	void Update () {
		t = GameObject.FindGameObjectWithTag ("Player").transform.position;
		if (transform.position.x <= -Camera.main.orthographicSize * Camera.main.aspect + camact.transform.position.x) {
			Destroy (this.gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		
		if (other.gameObject.tag == "Player" && other.gameObject.tag != "friend")
			other.gameObject.SetActive (false);
		else if(other.gameObject.tag!="1"){
			if (t.x > transform.position.x)
				rb.velocity = new Vector2 (2f, 0);
			else
				rb.velocity = new Vector2 (-2f, 0);
				
				
		}
	}



	}

