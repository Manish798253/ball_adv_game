using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraActor : MonoBehaviour {
	[SerializeField] private GameObject ballact;Vector3 initballpos,CamPos,diff,ballpos;[SerializeField] GameObject pl;

	float i,initcampos;GameObject sky,player;public int c = 0;[SerializeField]private  GameObject scene;int g;

	void Start () {
		
		initballpos = ballact.transform.position;initcampos = transform.position.x;CamPos = transform.position;
	}


	void FixedUpdate () {
		if (ballact.transform.position.x >= 201&& g==0) {
			g++;player = ballact;
			Instantiate (pl, ballact.transform.position, transform.rotation, null);
			(GameObject.FindGameObjectWithTag("Player")).SetActive(false);Destroy (player.gameObject);
			ballact = pl;
		}
	
		if (ballact != GameObject.FindGameObjectWithTag ("Player2")) {
			ballpos = ballact.transform.position;
			diff = ballpos - initballpos;
			transform.position = CamPos + diff;

		

		}


		for (int f = 0; f < scene.transform.childCount; f++) {
			
			if (((scene.transform.GetChild (f).transform.position.x) > (Camera.main.orthographicSize * Camera.main.aspect + transform.position.x)) || ((scene.transform.GetChild (f).transform.position.x+9f) < (-Camera.main.orthographicSize * Camera.main.aspect + transform.position.x)))
				scene.transform.GetChild (f).gameObject.SetActive (false);
			else {
				if(scene.transform.GetChild (f).gameObject.tag!="spider")
				scene.transform.GetChild (f).gameObject.SetActive (true);
			}
		}


}

}

