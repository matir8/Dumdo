using UnityEngine;
using System.Collections;

public class ShotController : MonoBehaviour
{
    public int damage = 10;
    public bool isEnemyShot = false;
    public float shotY = 0.2f;
    // Use this for initialization
    void Start()
    {
        transform.Translate(0, shotY, 0);
        Destroy(gameObject, 20f);

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<HealthController>().isEnemy != isEnemyShot)
        {
            Destroy(gameObject);
            ScoreController.score += EnemyController.scoreValue;
        }
    }
}
