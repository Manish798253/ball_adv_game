using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public static class utils  {
	


	public static void sceneloader (int s) {
		if (s == 0) {
			SceneManager.LoadScene (0);
		} else if (s == 1) {
			SceneManager.LoadScene (1);

		} else if (s == 2) {
			SceneManager.LoadScene (4);
		}
	}
}
