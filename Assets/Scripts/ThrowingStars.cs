using UnityEngine;
using System.Collections;

public class ThrowingStars : MonoBehaviour {
    [SerializeField]
    GameObject NStar;
    [SerializeField]
    GameObject FirePoint;

    public Rigidbody2D rb;
    public float speed;

	void FixedUpdate ()
    {
        speed = 100;
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(NStar, FirePoint.transform.position, FirePoint.transform.rotation); 
        }
	}
}
