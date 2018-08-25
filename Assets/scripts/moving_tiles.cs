using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_tiles : MonoBehaviour {
	public referralsoftilesmovemet reff_of_tiles;float time=0,movementvalue,time1; Vector3 velocity;[SerializeField] public float increased_value_of_ball_velocity; 
	// Use this for initialization
	void Start () {
		movementvalue = reff_of_tiles.movement;time1 = reff_of_tiles.time;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (time <= time1)
			transform.Translate (new Vector3 (movementvalue, 0, 0));
		else {
			time = 0;movementvalue = -movementvalue;
		}
		time = time + Time.deltaTime;
	

	}


}
