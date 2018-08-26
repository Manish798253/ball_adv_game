using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket_firing : MonoBehaviour {
	float time=0;[SerializeField] GameObject go;
	void Start () {
		
	}
	

	void FixedUpdate () {
		if(time==0)
			Instantiate (go, go.transform.position, go.transform.rotation, null);
		time = time + Time.deltaTime;
		if (time >= 1)
			time = 0;
		
		}
	}

