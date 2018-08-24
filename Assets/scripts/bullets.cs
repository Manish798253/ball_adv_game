using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bullets : MonoBehaviour {
	BoxCollider2D boxcollider2d;[SerializeField]private GameObject go;[SerializeField]private ballActor ballact;[SerializeField]Text pressalt;
	float time = -1f, d = 0,j=0;// Use this for initialization
	void Start () {
		boxcollider2d = GetComponent<BoxCollider2D> ();pressalt.text = " ";
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (d==1) {
			if(Input.GetKeyDown(KeyCode.RightAlt))
			GetBullet ();
			gameObject.transform.position = ballact.transform.position;
		}
	}
	void Update(){
		if (time >= 0f && time <= 2f) {
			time = time + Time.deltaTime;
			pressalt.text = "Press alt now to fire bullet";j = 0;
		} else if(j==0) {
			pressalt.text = " ";time = -1f;j = 1;
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("enter");
		if (other.gameObject.tag == "Player"&&d==0) {
			this.gameObject.GetComponent<SpriteRenderer> ().sortingLayerName = "Default";time = 0f;d = 1;
		}
	}
	void GetBullet()
	{
		
			Instantiate (go, ballact.transform.position+ballact.GetComponent<CircleCollider2D>().radius*Vector3.right, go.transform.rotation, null);




	

}

}
