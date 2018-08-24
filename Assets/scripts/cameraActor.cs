using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraActor : MonoBehaviour {
	[SerializeField] private GameObject ballact;Vector3 initballpos,CamPos,diff,ballpos;[SerializeField] GameObject pl;
	// Use this for initialization
	float i,initcampos;GameObject sky,player;public int c = 0;[SerializeField]private  GameObject scene;int g;

	void Start () {
		//sky = GameObject.FindGameObjectWithTag ("sky");
		initballpos = ballact.transform.position;initcampos = transform.position.x;CamPos = transform.position;
	}

	// Update is called once per framege
	void FixedUpdate () {
		if (ballact.transform.position.x >= 201&& g==0) {
			g++;player = ballact;
			Instantiate (pl, ballact.transform.position, transform.rotation, null);
			(GameObject.FindGameObjectWithTag("Player")).SetActive(false);Destroy (player.gameObject);
			ballact = pl;//initballpos = ballact.transform.position;
		}
		Debug.Log ("ballpos: "+ ballpos+" diff: "+diff+" initballpos: "+initballpos+" initcampos: "+initcampos);
		if (ballact != GameObject.FindGameObjectWithTag ("Player2")) {
			ballpos = ballact.transform.position;
			diff = ballpos - initballpos;
			transform.position = CamPos + diff;
			Debug.Log ("ballact: " + ballact);
		
			Debug.Log (Camera.main.orthographicSize + " " + 4);
		}

		//float getmax = getskymaxrightxvaluex ();Debug.Log ("camera_height*aspect_ratio+its_middle_point : "+((Camera.main.orthographicSize * Camera.main.aspect) + Camera.main.transform.position.x)+"  and getmax: "+getmax);
		/*if ((Camera.main.orthographicSize * Camera.main.aspect + Camera.main.transform.position.x) >= getmax) {
			print ("pakkkkkk");
			sky.GetComponent<Rigidbody2D> ().MovePosition (Camera.main.transform.position.x * Vector2.right - initcampos * Vector2.right);
				c = 1;
			//sky.GetComponent<Rigidbody2D> ().velocity.Set (sky.GetComponent<Rigidbody2D> ().velocity.x, 0f);
		}*/
		for (int f = 0; f < scene.transform.childCount; f++) {
			
			if (((scene.transform.GetChild (f).transform.position.x) > (Camera.main.orthographicSize * Camera.main.aspect + transform.position.x)) || ((scene.transform.GetChild (f).transform.position.x+9f) < (-Camera.main.orthographicSize * Camera.main.aspect + transform.position.x)))
				scene.transform.GetChild (f).gameObject.SetActive (false);
			else {
				if(scene.transform.GetChild (f).gameObject.tag!="spider")
				scene.transform.GetChild (f).gameObject.SetActive (true);
			}
		}


}
	/*public float getskymaxrightxvaluex ()
	{
		
		return sky.GetComponent<BoxCollider2D> ().bounds.max.x;


	}
	public float getskymaxrightxvaluey ()
	{

		return sky.GetComponent<BoxCollider2D> ().bounds.max.y;


	}*/
}

