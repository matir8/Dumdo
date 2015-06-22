using UnityEngine;
using System.Collections;

public class GameOverController : MonoBehaviour
{

    void Update()
    {
        if (gameObject.GetComponent<HealthController>().hp <= 0)
        {
            Application.LoadLevel("Game Over");
        }
    }
}
