using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hangingtiles_mov : MonoBehaviour {
	[SerializeField]private GameObject hanging_tiles; private int position_of_2nd_Tile;public  float vel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	void OnCollisionStay2D(Collision2D other)
	{
		Debug.Log (hanging_tiles.transform.GetChild (0) + "and, " + hanging_tiles.transform.GetChild (1)+"vel of tile "+GetComponent<Rigidbody2D> ().velocity );
		if (other.gameObject.tag == "Player") {
			if (gameObject == hanging_tiles.transform.GetChild (0).gameObject) {
				position_of_2nd_Tile = 1;Debug.Log (1);
				hanging_tiles.transform.GetChild (position_of_2nd_Tile - 1).transform.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -2);
				hanging_tiles.transform.GetChild (position_of_2nd_Tile).transform.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,2);


			} else if (gameObject == hanging_tiles.transform.GetChild (1).gameObject) {
				position_of_2nd_Tile = 0;Debug.Log (1);
				hanging_tiles.transform.GetChild (position_of_2nd_Tile+1).transform.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,-2);
				hanging_tiles.transform.GetChild (position_of_2nd_Tile).transform.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,2);

			}
			//other.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -2);
			Debug.Log (other.gameObject.GetComponent<Rigidbody2D> ().velocity.y+"ball and tile"+ GetComponent<Rigidbody2D> ().velocity.y);

		}

	}
		void OnCollisionExit2D(Collision2D other)
		{
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);hanging_tiles.transform.GetChild (position_of_2nd_Tile).transform.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
		}


		}

