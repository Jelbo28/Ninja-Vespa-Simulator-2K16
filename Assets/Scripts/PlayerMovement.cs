using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	Rigidbody2D rb;

	[SerializeField]
	float speed = 120f;

    [SerializeField]
    Animator anim;  
	
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

	void FixedUpdate ()
    {
		

        rb.GetComponent<Rigidbody2D>();

		if (Input.GetKey (KeyCode.A)) {
			rb.AddForce (Vector3.left * speed);
			anim.SetBool ("GoingRight", false);
			anim.SetBool ("GoingLeft", true);
		} else if (Input.GetKey (KeyCode.D)) {
			rb.AddForce (Vector3.right * speed);
			anim.SetBool ("GoingLeft", false);
			anim.SetBool ("GoingRight", true);
		} else if (Input.GetKeyDown (KeyCode.W)) {
			rb.AddForce (Vector3.up * 300);
		} 
		else
		{
			anim.SetBool("GoingLeft", false);
			anim.SetBool("GoingRight", false);
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
