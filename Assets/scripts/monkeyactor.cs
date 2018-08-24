using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monkeyactor : MonoBehaviour {
	float jumprange,time=0,time1,d=1,q,w=1,r=1,destination,init,g,reactiontime,decider_for_jump_or_down,maxorminbound;[SerializeField]private float jump=0;bool jumpornot=false,skipdown=false;
	[SerializeField]private float a, b;[SerializeField]public GameObject Go;float v,f;bool col=false;GameObject go1;aauzar aauzar;
	// Use this for initialization
	void Start () {
		go1 = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (this.GetComponent<BoxCollider2D> ().isTrigger == false)
			destination = 0;
		Debug.Log ("time: " + time + ", jump: " + jump + ", a value: " + a + ", destination: " + destination + " ,decider_for_jump_or_down: " + decider_for_jump_or_down + ",reaction time: " + reactiontime); 
		if (reactiontime == 0 && gameObject.GetComponent<Rigidbody2D>().velocity.y==0) {
			reactiontime = Mathf.Floor (Random.Range (a, b));decider_for_jump_or_down = Mathf.Floor (Random.Range (0, 2));
		}

		if (reactiontime != 0) {
			if (((jump <= 1 && decider_for_jump_or_down == 0) || (jump == 0))) {
				if(time>=reactiontime)
				{
				jumpornot = true;
					gameObject.GetComponent<BoxCollider2D> ().isTrigger = true;
					col = false;}
				maxorminbound = gameObject.GetComponent<BoxCollider2D> ().bounds.min.y;
				if (destination >= maxorminbound && destination != 0) {
					gameObject.GetComponent<BoxCollider2D> ().isTrigger = true;
				}
				else if (destination != 0) {
					gameObject.GetComponent<BoxCollider2D> ().isTrigger = false;Debug.Log ("trigger: " + gameObject.GetComponent<BoxCollider2D> ().isTrigger);
					jump++;
					reactiontime = 0;
					gameObject.GetComponent<Rigidbody2D> ().gravityScale = 1;
					time = 0;maxorminbound = 0;
				}
					
				
		
			} else {
				maxorminbound = gameObject.GetComponent<BoxCollider2D> ().bounds.min.y;
				if(time>=reactiontime)
				{
					gameObject.GetComponent<BoxCollider2D> ().isTrigger = true;jumpornot = false;col = false;
				}

				if (destination <= maxorminbound && destination != 0)
				{
					gameObject.GetComponent<BoxCollider2D> ().isTrigger = true;
				}
				else if (destination != 0)
				{
					
						gameObject.GetComponent<BoxCollider2D> ().isTrigger = false;
						jump--;				
					time = 0;

					reactiontime = 0;maxorminbound = 0;gameObject.GetComponent<Rigidbody2D> ().gravityScale = 1;
				}


			}
		

	
	
	
		}}

	void FixedUpdate()
	{  time1 = time1 + Time.deltaTime;
		if (gameObject.transform.position.x >= go1.transform.position.x)
			gameObject.GetComponent<SpriteRenderer> ().flipX = false;
	else
			gameObject.GetComponent<SpriteRenderer> ().flipX = true;
		if(gameObject.GetComponent<Rigidbody2D>().velocity.y==0 && col==true)
		time = time + Time.deltaTime;
		transform.rotation = new Quaternion (0, 0, 0, 0);
		if (jumpornot == true && gameObject.GetComponent<BoxCollider2D> ().isTrigger == true ) {
			gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0;
			gameObject.GetComponent<Rigidbody2D> ().AddForce (4f * Vector2.up);
				

		} else if (jumpornot == false && gameObject.GetComponent<BoxCollider2D> ().isTrigger == true) {
			
			gameObject.GetComponent<Rigidbody2D> ().gravityScale = 1;
		}
		v = Random.Range (.1f, .2f);f = Random.Range (0.1f, .25f);
		if (((time1 - Mathf.Floor (time1)) >= v && (time1 - Mathf.Floor (time1)) <= f)  || ((time1 - Mathf.Floor (time1)) >= v && (time1 - Mathf.Floor (time1)) <= f)) {
			Instantiate (Go, transform.position +  1.3f * Vector3.up, transform.rotation, null);aauzar = Go.GetComponent<aauzar> ();aauzar.go = gameObject;
		}
		if (time1 >= 6)
			time1= 0;
	}
	void OnTriggerEnter2D(Collider2D other)
	{  if (other.gameObject.tag == "blocks" || other.gameObject.tag == "ground1"||other.gameObject.tag=="ground") {
			if (gameObject.GetComponent<Rigidbody2D> ().velocity.y > 0)
				destination = other.gameObject.GetComponent<BoxCollider2D> ().bounds.max.y;
			else if (gameObject.GetComponent<Rigidbody2D> ().velocity.y < 0)
				destination = other.gameObject.GetComponent<BoxCollider2D> ().bounds.max.y;
		}
		if (other.gameObject.tag == "Player")
			other.gameObject.SetActive (false);
		
	}
	void OnTriggerStay2D(Collider2D other)
	{
	}
	void OnTriggerExit2D(Collider2D other)
	{  
		
	}
	void OnCollisionStay2D(Collision2D other)
	{
		col = true;Debug.Log(col);
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player")
			other.gameObject.SetActive (false);
	}


}