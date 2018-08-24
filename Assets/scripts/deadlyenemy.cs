using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deadlyenemy : MonoBehaviour {
	float time = 0, s = 0,m=0,a = 1;[SerializeField] private float forceup;float d=0,initpos,x=0,init=0;[SerializeField]private GameObject go,ballact;
	public float count=0;public Text deadlyenemy_bullets;string k;// Use this for initialization
	void Start () {
		init = transform.position.x;ballact = GameObject.FindGameObjectWithTag ("Player");deadlyenemy_bullets.text = " ";
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
			
		transform.rotation = new Quaternion (0, 0, 0, 0);
		if (count == 10) {
			Destroy (gameObject);
		}
		Debug.Log ("count is "+count);
		if (s == 1) {
			time = time + Time.deltaTime;
			if (time == Time.deltaTime) {
				initpos = transform.position.x;
			}
			if ((Mathf.Floor (time) == 1 ||Mathf.Floor (time) == 3 ||Mathf.Floor (time) == 5) && m == 0) {
				
				gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * forceup);
			} if (time >= 2 && time <= 3) {
				gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-2, gameObject.GetComponent<Rigidbody2D> ().velocity.y);


			}  if (time >= 3 && time <= 4) {
				
				gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (2, gameObject.GetComponent<Rigidbody2D> ().velocity.y);
			} 
			if (time >= 2 && time <= 3)
				m = 0;
			if (time >= 4 && time <= 5)
				m = 0;
			if (time >= a+1 && time <= a+2)
				d = 0;
			if (time >= a+3 && time <= a+4)
				d = 0;

			if ((Mathf.Floor(time)== a||Mathf.Floor(time)== a+2||Mathf.Floor(time)== a+4) &&d==0 && GameObject.FindGameObjectWithTag("Player")!=null) {
				Instantiate (go, transform.position + Vector3.up * 2, transform.rotation, null);d++;a = Mathf.Floor( Random.Range (0, 5));



			}
			if (time >= 5) {
				time = 0;
			}

			if (transform.position.x >= ballact.transform.position.x)
				gameObject.GetComponent<SpriteRenderer> ().flipX = false;
			else
				gameObject.GetComponent<SpriteRenderer> ().flipX = true;


		
		} else {
			time = time + Time.deltaTime;
			if ((transform.position.x < init) &&s==0 ) {
					gameObject.GetComponent<SpriteRenderer> ().flipX = true;
				gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (2, 0);time = 0;
				
				Debug.Log ("1st");
			} 
			if (time>0 && time <= 2) {
				gameObject.GetComponent<SpriteRenderer> ().flipX = false;
				gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-4, 0);
				s += 2;
			} else if (time >= 2 && time <= 4) {
				
				gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (4, 0);

					gameObject.GetComponent<SpriteRenderer> ().flipX = true;

			} else if(time>=4) {
				time = 0;gameObject.GetComponent<SpriteRenderer> ().flipX = false;
			
			}

		}
	}
	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			s = 1;deadlyenemy_bullets.text = "Fire " + (10f - count)+ " bullets to kill ";
		}
	}
				void OnTriggerExit2D(Collider2D other)
				{
		a = 1;
		if (other.gameObject.tag == "Player") {
			s = 0;deadlyenemy_bullets.text = " ";
		}
		}

	void OnCollisionEnter2D(Collision2D other)
	{ 
		if (other.gameObject.tag == "Player") {
			other.gameObject.SetActive (false);
		}
		
	}

}
