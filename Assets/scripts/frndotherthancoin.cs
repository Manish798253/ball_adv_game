using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frndotherthancoin : MonoBehaviour {
	[SerializeField]public static BoxCollider2D boxcol2d;

	void Awake () {
		boxcol2d = GetComponent<BoxCollider2D> ();
	}
	


	public static float max()
	{
		return boxcol2d.bounds.max.y;

	}

}
