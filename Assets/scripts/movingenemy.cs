using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingenemy : MonoBehaviour {
	[SerializeField]private  cameraActor camact;float time=0f;[SerializeField]private ballActor ballact;
	[SerializeField]private GameObject go;[SerializeField] private float vax=0,g,rotval;private Rigidbody2D rb;float f=0;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	

	void FixedUpdate () {
		rb.AddForce (9.81f*Vector2.up);

		time =time+ Time.deltaTime;
		if (time >= 5) {
			
			GameObject.Instantiate (go, transform.position, go.transform.rotation,null);
			time = 0;
	}

		if ((ballact.transform.position.x - transform.position.x )>= vax && Mathf.Floor( ballact.GetComponent<Rigidbody2D> ().velocity.x) > 0) {
			rb.velocity=new Vector2(ballact.GetComponent<Rigidbody2D> ().velocity.x,0);

		}
		else
			oscillation() ;
}
	void oscillation()
	{
		if ((ballact.transform.position.x < (transform.position.x + rotval)) && f != 1) {
			rb.velocity = new Vector2 (-2f, 0);
		}
		else {
			
			rb.velocity = new Vector2 (2f, 0);f = 1;
			if ((ballact.transform.position.x + rotval) <= transform.position.x)
				f = 0;
		}


	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "bullet") {
			Destroy (gameObject);
			Destroy (other.gameObject);
		}

	}

}
