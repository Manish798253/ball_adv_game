using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
[RequireComponent(typeof(AudioSource))]
public class goli : MonoBehaviour {
	[SerializeField]private  GameObject bullet;AudioClip a;AudioSource audioso;float  m=3.14f/180f,initcampos;
	[SerializeField]GameObject go;int limit;Vector3 campos,initball,diff;int s=0;GameObject sky;
	// Use this for initialization
	void Start () {
		initcampos = 0;
		audioso=GetComponent<AudioSource>();campos = Camera.main.transform.position;initball = transform.position;
	}
	void Update()
	{
		if (s == 0) {
			campos = Camera.main.transform.position;s++;initball = transform.position;
		}
		if (GameObject.FindGameObjectsWithTag ("spider").Length < 6) {
			if (limit <= 12) {
				respawn ();limit += 1;
			}

		}


	}

	// Update is called once per frame
	void FixedUpdate () {

		diff = transform.position - initball;Camera.main.transform.position=campos+diff;initball = transform.position;
		campos = Camera.main.transform.position;

		/*float getmax = getskymaxrightxvaluex ();
		if ((Camera.main.orthographicSize * Camera.main.aspect + Camera.main.transform.position.x) >= getmax) {
			print ("pakkkkkk");
			sky.GetComponent<Rigidbody2D> ().MovePosition (Camera.main.transform.position.x * Vector2.right - initcampos * Vector2.right);

			//sky.GetComponent<Rigidbody2D> ().velocity.Set (sky.GetComponent<Rigidbody2D> ().velocity.x, 0f);
		}*/

		RaycastHit2D hit = Physics2D.Raycast (transform.GetChild (0).transform.position, transform.GetChild (0).transform.position - transform.position, 5f);

		if (hit.collider != null && hit.collider.tag == "spider" && audioso.clip != null)
			audioso.Play ();

		if (Input.GetKeyDown (KeyCode.RightAlt)) {
			GameObject go = Instantiate (bullet, transform.GetChild (0).transform.position, transform.rotation, null);
			go.GetComponent<Rigidbody2D> ().velocity = Vector3.Normalize (transform.GetChild (0).transform.position - transform.position) * 9f;

		}
		if (Input.GetKey (KeyCode.A)) {
			GetComponent<Rigidbody2D> ().angularVelocity = 100;
			GetComponent<Rigidbody2D> ().velocity = Vector2.left * 2f;
		} else if (Input.GetKey (KeyCode.D)) {
			GetComponent<Rigidbody2D> ().angularVelocity = -100;
			GetComponent<Rigidbody2D> ().velocity = Vector2.right * 2f;
		} else if (GetComponent<Rigidbody2D> ().velocity != new Vector2 (0, 0)) {
			GetComponent<Rigidbody2D> ().AddForce (-Vector3.Normalize (GetComponent<Rigidbody2D> ().velocity));
			GetComponent<Rigidbody2D> ().angularVelocity = 0;
		}
	}
	void respawn()
	{float init = Camera.main.transform.position.x, final = Camera.main.aspect * Camera.main.orthographicSize + init, tukka=Random.Range(init,final);
		Instantiate (go, new Vector3 (tukka,Camera.main.orthographicSize+Camera.main.transform.position.y+3f , 0), go.transform.rotation, null);
		Instantiate (go, new Vector3 (tukka-final+init,Camera.main.orthographicSize+Camera.main.transform.position.y+3f , 0), go.transform.rotation, null);
	}
	/*public float getskymaxrightxvaluex ()
	{

		return sky.GetComponent<BoxCollider2D> ().bounds.max.x;


	}*/
}
