using UnityEngine;
using System.Collections;

public class ThrowingStars : MonoBehaviour {
    [SerializeField]
    GameObject NStar;
    [SerializeField]
    GameObject FirePoint;

    public Rigidbody2D rb;
    public float speed;

	private bool FiredRecently;

	void Start()
	{
		FiredRecently = false;
	}

	void FixedUpdate ()
    {
        speed = 100;
        if (Input.GetKeyDown(KeyCode.E))
        {
			if (FiredRecently == false) 
			{
				GameObject obj = ThePoolerofObjects.current.GetPooledObject();

				if (obj == null) return;

				obj.transform.position = FirePoint.transform.position;
				obj.transform.rotation = FirePoint.transform.rotation;
				obj.SetActive(true);
				obj.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.right * 5, ForceMode2D.Impulse);

				FiredRecently = true;

				BoolResetting ();
			}
        }
	}

	void BoolResetting()
	{
		StartCoroutine (Bool ());
	}

	IEnumerator Bool()
	{
		yield return new WaitForSeconds (2f);

		FiredRecently = false;
	}
}
