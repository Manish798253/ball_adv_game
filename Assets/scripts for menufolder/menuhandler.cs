using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuhandler : MonoBehaviour {
	[SerializeField]private GameObject menu;int s, f=0;bool justify=true;

	void Start () {
		transform.position = menu.transform.GetChild (f).GetComponent<BoxCollider2D> ().bounds.center;
	}
	

	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			s = 0;justify = true;
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			s = 1;justify = true;
		}
		

		while(s==0&& f!=0&&justify==true)
		{
			transform.position=menu.transform.GetChild(--f).GetComponent<BoxCollider2D>().bounds.center;justify = false;
			
			
	}
		while (s == 1 && f != 2&&justify==true) {
			transform.position=menu.transform.GetChild(++f).GetComponent<BoxCollider2D>().bounds.center;justify = false;
		}




		if (Input.GetKey(KeyCode.Return)) {
			

				utils.sceneloader (f+1);

			
		}
	}
}
