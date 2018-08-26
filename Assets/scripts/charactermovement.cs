using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactermovement : MonoBehaviour {
	private float velocity=-2f;Vector3 movement_along_of_character,movement_sideways_of_character; int i=1;float time=0;
	[SerializeField] GameObject go;int f;float var_time;

	void Start () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, velocity);var_time = Random.Range (.4f, 1);

	}






	void FixedUpdate () {
		if (GameObject.FindGameObjectWithTag ("Player2")!=null) {
			movement_along_of_character = (-GameObject.FindGameObjectWithTag ("Player2").transform.position + transform.position);
		 
			if (Mathf.Abs (Vector3.Magnitude (transform.position - GameObject.FindGameObjectWithTag ("Player2").transform.position)) <= 18) {

				time = time + Time.deltaTime;
				if (time <= var_time)
					i = 1;
				else if (time >= var_time && time <= 2 * var_time)
					i = -1;
				else {
					time = 0;
					var_time = Random.Range (.4f, 1);
					i = 1;
				}
				movement_along_of_character = Vector3.Normalize (GameObject.FindGameObjectWithTag ("Player2").transform.position - transform.position);
				velocity = 1f;
				movement_sideways_of_character = Vector3.Cross (movement_along_of_character, new Vector3 (0, 0, 1)) * 2.8f;
				GetComponent<Rigidbody2D> ().velocity = movement_along_of_character * velocity + (i * movement_sideways_of_character);
				f = 1;
			} else if (f == 1) {
				velocity = -2f;
				movement (-2f);
				f = 0;
			}
		}
		if (GetComponent<Rigidbody2D> ().velocity.y > 0 && transform.position.y >= 12) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -velocity);velocity = -velocity;
			time = 0;
		}
		if (transform.position.x > GameObject.FindGameObjectWithTag ("Player2").transform.position.x)
			GetComponent<SpriteRenderer> ().flipX = true;
		else
			GetComponent<SpriteRenderer> ().flipX = false;



	}

	void OnCollisionEnter2D(Collision2D other)
	{
		
		if(other.collider!=null)
		if ((other.collider.transform.parent!=null&& other.collider.transform.parent.tag == "ground")) {
			velocity = -velocity;
			movement (velocity);
		} else if (other.collider.tag == "Player2")
			other.gameObject.SetActive (false);
		else if (other.collider.tag == "spider")
			movement (velocity);

	}
	void OnCollisionStay2D(Collision2D other)
	{
		if (other.collider.tag == "spider")
			movement (velocity);
		
	}

	void movement(float vel)
	{
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,vel);
	}

}
