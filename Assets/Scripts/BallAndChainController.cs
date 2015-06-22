using UnityEngine;
using System.Collections;

public class BallAndChainController : MonoBehaviour
{
    Vector3 pos;
    public int speed = 100;
    public int damage = 10;
    // Use this for initialization
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pos, Vector3.forward, speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        col.gameObject.GetComponent<HealthController>().Damage(damage);
    }
}
