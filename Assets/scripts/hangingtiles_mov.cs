using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hangingtiles_mov : MonoBehaviour {
	[SerializeField]private GameObject hanging_tiles; private int position_of_2nd_Tile;public  float vel;

	void Start () {
		
	}
	

	void FixedUpdate () {
		
	}

	void OnCollisionStay2D(Collision2D other)
	{
		
		if (other.gameObject.tag == "Player") {
			if (gameObject == hanging_tiles.transform.GetChild (0).gameObject) {
				position_of_2nd_Tile = 1;
				hanging_tiles.transform.GetChild (position_of_2nd_Tile - 1).transform.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -2);
				hanging_tiles.transform.GetChild (position_of_2nd_Tile).transform.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,2);


			} else if (gameObject == hanging_tiles.transform.GetChild (1).gameObject) {
				position_of_2nd_Tile = 0;
				hanging_tiles.transform.GetChild (position_of_2nd_Tile+1).transform.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,-2);
				hanging_tiles.transform.GetChild (position_of_2nd_Tile).transform.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,2);

			}


		}

	}
		void OnCollisionExit2D(Collision2D other)
		{
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);hanging_tiles.transform.GetChild (position_of_2nd_Tile).transform.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
		}


		}

