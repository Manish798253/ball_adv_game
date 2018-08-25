using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName="Content/moving_tiles__type")]
public class referralsoftilesmovemet:ScriptableObject
{
	[Range(-4,4)]
	public float movement;
	[Range(-3,3)]
	public float time;

}