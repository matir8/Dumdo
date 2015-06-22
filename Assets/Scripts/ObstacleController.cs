using UnityEngine;
using System.Collections;

public class ObstacleController : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D otherCollider)
    {

        ShotController shot = otherCollider.gameObject.GetComponent<ShotController>();
        if (shot != null)
        {
                Destroy(shot.gameObject);          
        }
    }
}