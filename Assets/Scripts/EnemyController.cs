using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    private Shooting[] weapons;
    BoxCollider2D boxCollider;
    MoveController enemyMovement;
    float pos;
    public static int scoreValue = 20;
    public bool isTurnedLeft = true;
    void Awake()
    {
        // Retrieve the weapon only once
        weapons = GetComponentsInChildren<Shooting>();
    }

    void Update()
    {
        foreach (Shooting weapon in weapons)
        {
            // Auto-fire
            if (weapon != null && weapon.CanAttack)
            {
                weapon.Attack(true);
            }
        }
        if (isTurnedLeft)
        {
            transform.Translate(Vector3.right * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 180, 0);

            enemyMovement.direction.x = -1;
        }


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        enemyMovement = gameObject.GetComponent<MoveController>();


        if (collision.gameObject.tag == "GoLeft")
        {

            isTurnedLeft = true;
            transform.Translate(Vector3.right * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 180, 0);

            enemyMovement.direction.x = -1;


        }
        if (collision.gameObject.tag == "GoRight")
        {
            isTurnedLeft = false;
            transform.Translate(Vector3.right * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0, 0);
            enemyMovement.direction.x = 1;
        }


    }





}

