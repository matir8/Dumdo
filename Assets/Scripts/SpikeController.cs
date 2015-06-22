using UnityEngine;
using System.Collections;

public class SpikeController : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject != GameObject.Find("PipeUp"))
        {
            col.gameObject.GetComponent<HealthController>().Damage(100);
        }
            
        
        
    }
}

