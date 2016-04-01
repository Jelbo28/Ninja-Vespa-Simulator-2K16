using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{
    [SerializeField]
    float distance = 75f;

    [SerializeField]
    Vector2 RayAngle = new Vector2(1, 1);

    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, RayAngle, distance);

        Debug.DrawRay(transform.localPosition, RayAngle, Color.yellow);
        if (hit.collider.tag == "Player")
        {
            Debug.Log("This thing is the player I think");
        }
    }	
}
