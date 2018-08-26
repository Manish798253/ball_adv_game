using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class ballActor : MonoBehaviour {
	[SerializeField]private GameObject emoji;
	private Rigidbody2D rb; public static CircleCollider2D circleccollider2D;Vector2 topmostposition; [SerializeField]private GameObject Ground;BoxCollider2D boxcolliderground;
	[SerializeField] private float value,valueofup,j;int a,w,d;float compare,s,groundfixed_y_min;public static bool destroy=false;public  enemyactor enemyact;
	frndotherthancoin frd;[SerializeField]private frndotherthancoin frnd;float l;public int x=0;[SerializeField]AudioMixerSnapshot snapshot_default,jump,down;
	// Use this for initialization
	void Start () {
		Ground =GameObject.FindGameObjectWithTag ("ground");boxcolliderground= Ground.GetComponent<BoxCollider2D> ();

		rb = GetComponent<Rigidbody2D> ();circleccollider2D = GetComponent<CircleCollider2D> ();	compare = boxcolliderground.bounds.min.y;groundfixed_y_min = compare;
	}


	void FixedUpdate () {


		if (Input.GetKey (KeyCode.D))
		{

			rb.velocity = new Vector2 (value, rb.velocity.y);
			rb.angularVelocity = -760;


	} if (Input.GetKey(KeyCode.A))
		{
			rb.velocity = new Vector2 (-value, rb.velocity.y);
			rb.angularVelocity = 760;

		}

		if (Input.GetKey(KeyCode.Space)) { 
			rb.velocity.Set(rb.velocity.x, 0f);
			if(s==1) 
		    rb.AddForce(Vector2.up * valueofup);
			


			s = 0;

		} 
		if((Input.GetKey(KeyCode.A))==false && (Input.GetKey(KeyCode.D))==false) {

			rb.velocity = new Vector2 ( 0 , rb.velocity.y);
			rb.angularVelocity = 0;

		}
		if (transform.position.y <= boxcolliderground.bounds.min.y) {
			gameObject.SetActive (false);
		}


	}
	void OnCollisionEnter2D( Collision2D contactInfo)
	{
		


		down.TransitionTo (.1f);



	}


	void OnCollisionStay2D(Collision2D contactInfo)
	{ 
		if ( transform.position.y>=contactInfo.collider.bounds.max.y-.1f )
			s = 1;
		
		
		


		destroy = false;

		Collider2D other = contactInfo.collider;

		l = (circleccollider2D.bounds.max.y - frndotherthancoin.max ());
		j = 2 * circleccollider2D.radius;
		float v = l, i = 0, h=0;
		if(other.gameObject.GetComponent<Rigidbody2D> () != null && other.gameObject.tag=="enemy") 
		{
			while (i < 2) {
				if (v * 10 < 1) {
					v = v * 10;
					continue;
				}
				h = Mathf.Floor (v);
				h = h / 10;
				if (i == 0)
					l = h;
				else
					j = h;
				i++;
				v = j;

			}
		}

		if (other.gameObject.GetComponent<Rigidbody2D> () != null) {
			
			destroy = true;
		}
		if (destroy == true && Mathf.Floor (other.gameObject.GetComponent<Rigidbody2D> ().velocity.y) < 0 && l == j && other.gameObject.tag!="sky") {
			gameObject.SetActive (false);
		}


	}
	void OnCollisionExit2D()
	{s = 0;
		jump.TransitionTo(0);
	}
}



