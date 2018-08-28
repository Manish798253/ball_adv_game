using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Utils:MonoBehaviour  {
	public GameObject emoji;int s=0,i,length_rb;float time=0;public Text gameover;Transform[] pause;Vector2[] velocity;

	void Start()
	{
		gameover.text = " ";pause =GameObject .FindObjectsOfType<Transform> ();
	}

	void Update ()
	{pause =GameObject .FindObjectsOfType<Transform> ();
		
		if (Input.GetKey (KeyCode.Escape)) {
			Camera.main.transform.GetChild (0).GetComponent<AudioSource> ().Pause ();
			gameover.text = "PAUSED..Press enter to continue";
			for (i = 0; i < pause.Length; i++) {
				if (pause [i].gameObject.GetComponent<Rigidbody2D> () != null) {
					pause [i].GetComponent<Rigidbody2D> ().Sleep ();
				}
				if(pause[i].GetComponent<MonoBehaviour>()!=null &&pause[i].gameObject!=gameObject&&pause[i].gameObject.layer!=5)
				pause [i].gameObject.GetComponent<MonoBehaviour> ().enabled = false;
			}
		}
		if (Input.GetKey (KeyCode.Return)) {
			Camera.main.transform.GetChild (0).GetComponent<AudioSource> ().UnPause ();
			gameover.text = " ";
			for (i = 0; i < pause.Length; i++) {
				if (pause [i].GetComponent<Rigidbody2D> () != null) {
					pause [i].GetComponent<Rigidbody2D> ().WakeUp ();
				}
				 if (pause [i].GetComponent<MonoBehaviour> () != null)
					pause [i].gameObject.GetComponent<MonoBehaviour> ().enabled = true;

			}
		}
		if (GameObject.FindGameObjectWithTag ("Player") == null && s == 0&&GameObject.FindGameObjectWithTag ("Player2") == null) {
			s = 1;
			Instantiate (emoji, Camera.main.transform.position + new Vector3 (0, 7, 0), emoji.transform.rotation, null);

		}
		if (GameObject.FindGameObjectWithTag ("Player") == null && GameObject.FindGameObjectWithTag ("Player2") == null) {
			time = time + Time.deltaTime;Camera.main.transform.GetChild (0).GetComponent<AudioSource> ().Stop ();
			gameover.text = "GAME OVER";
			if (time >= 4f)
				SceneManager.LoadScene (0);
		}
	}
}













	
