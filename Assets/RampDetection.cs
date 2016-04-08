using UnityEngine;
using System.Collections;

public class RampDetection : MonoBehaviour 
{
	[SerializeField]
	Vector2 RayAngle = new Vector2(1, 1);

	[SerializeField]
	float distance = 75f;

	void FixedUpdate () 
	{
		RaycastHit2D hit = Physics2D.Raycast(transform.localPosition, RayAngle, distance);

		Debug.DrawRay(transform.localPosition, RayAngle, Color.red);

		if (hit.collider.tag == "Ramp") 
		{
			Debug.Log ("I think there's a ramp underneath me");
		}
	}
}
