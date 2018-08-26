using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class locker_end_of_scene : MonoBehaviour {
	public Text is_there_a_key_or_not;
	void Start () {
		is_there_a_key_or_not.text = " ";
	}
	


	void OnTriggerStay2D(Collider2D other)
	{
		if (GameObject.FindGameObjectWithTag("key").transform.position.x>=transform.position.x-1f) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex % 4 +1);

		} else if (other.transform.position.x>=gameObject.transform.position.x && (other.gameObject.tag =="Player"||other.gameObject.tag=="Player2"))
			is_there_a_key_or_not.text = "Bring Key";
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player"||other.gameObject.tag=="Player2")
			is_there_a_key_or_not.text = " ";
	}
}
