using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadfire : MonoBehaviour {
	float time=0;Vector3 initposball,initposfire,diff;[SerializeField]private float velocity=2;GameObject go;

	void Start () {
		go = GameObject.FindGameObjectWithTag ("Player");
	}
	

	void FixedUpdate () {
		time = time+Time.deltaTime;

		if (Mathf.Floor(time)==Mathf.Floor(1)) {
			gameObject.GetComponent<Rigidbody2D> ().velocity = -diff.normalized*velocity;
		} else {
			initposball = go.transform.position;
			initposfire = transform.position;diff = (initposfire - initposball);

		}
		if ((((transform.position.x +2f)< go.transform.position.x) &&gameObject.GetComponent<Rigidbody2D> ().velocity.x <0 )||((transform.position.x > (go.transform.position.x +2))&&gameObject.GetComponent<Rigidbody2D> ().velocity.x >0 ))
			Destroy (gameObject);

	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player" || other.gameObject.tag=="blocks" )
		{
			 Destroy (gameObject);
			if (other.gameObject.tag == "Player")
				other.gameObject.SetActive (false);
			else
				Destroy (other.gameObject);
	}
		if(other.gameObject.tag=="ground")
		{
			Destroy (gameObject);
		}


}
}
