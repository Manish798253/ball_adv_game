using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket_firing : MonoBehaviour {
	float time=0;[SerializeField] GameObject go;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(time==0)
			Instantiate (go, go.transform.position, go.transform.rotation, null);
		time = time + Time.deltaTime;
		if (time >= 1)
			time = 0;
		
		}
	}

