using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

   public Rigidbody2D rb;
    public float speed = 120f;
    
	
	void FixedUpdate ()
    {
        rb.GetComponent<Rigidbody2D>();
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed);
        }
        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.up * 300);
        }

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Ground" || other.tag == "Ramp") 
		{
			rb.constraints = RigidbodyConstraints2D.FreezeRotation;

			this.gameObject.transform.rotation = other.transform.rotation;
		}
	}
}
