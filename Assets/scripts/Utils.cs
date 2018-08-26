using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Utils:MonoBehaviour  {
	public GameObject emoji;int s=0,i;float time=0;public Text gameover;SpriteRenderer[] pause;
	// Use this for initialization
	void Start()
	{
		gameover.text = " ";pause =GameObject .FindObjectsOfType<SpriteRenderer> ();
	}
	// Update is called once per frame
	void Update ()
	{Debug.Log ("yes $$$$$$");pause =GameObject .FindObjectsOfType<SpriteRenderer> ();
		if (Input.GetKey (KeyCode.Escape)) {
			gameover.text = "PAUSED..Press enter to continue";
			for (i = 0; i < pause.Length; i++) {
				if(pause[i].gameObject.GetComponent<Rigidbody2D>()!=null)
					pause [i].GetComponent<Rigidbody2D>().Sleep ();
				if(pause[i].GetComponent<MonoBehaviour>()!=null &&pause[i].gameObject!=gameObject)
				pause [i].gameObject.GetComponent<MonoBehaviour> ().enabled = false;
			}
		}
		if (Input.GetKey (KeyCode.Return)) {
			gameover.text = " ";
			for (i = 0; i < pause.Length; i++) {
				if (pause [i].GetComponent<Rigidbody2D> () != null)
					pause [i].GetComponent<Rigidbody2D>().WakeUp ();
				if (pause [i].GetComponent<MonoBehaviour> () != null)
					pause [i].gameObject.GetComponent<MonoBehaviour> ().enabled = true;

			}
		}
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













	
