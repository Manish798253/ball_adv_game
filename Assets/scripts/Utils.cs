using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Utils:MonoBehaviour  {
	public GameObject emoji;int s=0;float time=0;public Text gameover;
	// Use this for initialization
	void Start()
	{
		gameover.text = " ";
	}
	// Update is called once per frame
	void Update ()
	{Debug.Log ("yes $$$$$$");
		if (Input.GetKey (KeyCode.Escape))
			SceneManager.LoadScene (0);
		if (GameObject.FindGameObjectWithTag ("Player") == null && s == 0) {
			s = 1;Debug.Log ("yes $$$$$$");
			Instantiate (emoji, Camera.main.transform.position + new Vector3 (0, 7, 0), emoji.transform.rotation, null);
			//Destroy (this. gameObject);
		}
		if (GameObject.FindGameObjectWithTag ("Player") == null && GameObject.FindGameObjectWithTag ("Player2") == null) {
			time = time + Time.deltaTime;
			gameover.text = "GAME OVER";
			if (time >= 4f)
				SceneManager.LoadScene (0);
		}
	}
}
