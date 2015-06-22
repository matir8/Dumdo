using UnityEngine;
using System.Collections;

public class MovingPlatformController : MonoBehaviour
{
    MoveController movement;
    // Use this for initialization
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        movement = gameObject.GetComponent<MoveController>();

        
        if (collider.tag == "GoLeft" )
        {
                transform.Translate(Vector3.right * Time.deltaTime);
                movement.direction.x = -1;


        }
        if (collider.tag == "GoRight" )
        {
            transform.Translate(Vector3.right * Time.deltaTime);
                movement.direction.x = 1;
        }
    }
}
