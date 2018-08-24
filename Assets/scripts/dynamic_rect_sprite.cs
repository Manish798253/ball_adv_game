using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dynamic_rect_sprite: MonoBehaviour {
	public Texture2D texture2d;Sprite s;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		s=Sprite.Create ( texture2d , new Rect(0,0,4,4),new Vector2( 0.5f,0));
		gameObject.AddComponent<SpriteRenderer> ().sprite = s;

	}
}
