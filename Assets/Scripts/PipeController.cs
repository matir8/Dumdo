using UnityEngine;
using System.Collections;

public class PipeController : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        gameObject.transform.Translate(new Vector3(0, 200, 0) * Time.deltaTime);
    }
}
