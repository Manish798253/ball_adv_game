using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class supporter_of_tiles : MonoBehaviour {
	GameObject go=null;float s=0,init_pos_of_tile;Sprite sprite1;[SerializeField]Texture2D texture2d;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	/*	Debug.Log (transform.localScale+"velocity of tile "+go +"is: "+go.GetComponent<Rigidbody2D> ().velocity.y + init_pos_of_tile+go.transform.position.y);
	//	if (s<=-.5) {
		//	go.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
		//}
			
			
		if (go != null) {
			s = -( go.transform.position.y - init_pos_of_tile);
			if (go.GetComponent<Rigidbody2D> ().velocity.y < 0) {
				//transform.parent.localScale = new Vector3 (1, 1+s, 1);
			//	Sprite.Create ( texture2d , new Rect(go.transform.parent.transform.position.x,go.transform.parent.transform.position.y,2,2),new Vector2( go.transform.parent.transform.position.x ,go.transform.parent.transform.position.y));
				Sprite.Create ( texture2d , new Rect(0,0,4,4),new Vector2( go.transform.parent.transform.position.x ,go.transform.parent.transform.position.y));
			} else if (go.GetComponent<Rigidbody2D> ().velocity.y > 0) {
				transform.parent.localScale = new Vector3 (1,1+s, 1);

			}
		}*/
	}
	void OnTriggerStay2D(Collider2D other)
	{
		/*if (other.gameObject.tag != "Player")
			go = other.gameObject;*/

	}
	void OnTriggerEnter2D(Collider2D other)
	{/*Debug.Log (other.gameObject + " :this one");
		if(other.gameObject.tag!="Player")
		{
			go = other.gameObject;
			init_pos_of_tile = go.transform.position.y;
			}*/
		if(other.gameObject.tag=="clip")
			other.gameObject.SetActive(false);
	}


}
