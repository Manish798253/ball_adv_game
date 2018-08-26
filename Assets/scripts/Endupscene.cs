using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Endupscene : MonoBehaviour {


	void FixedUpdate () {
		if (Input.GetKey (KeyCode.Escape)) {
			SceneManager.LoadScene (0);
		}
	}
}
