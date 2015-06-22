using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float force = 10.0f;
    public Rigidbody2D rb;
    public Vector2 vector = new Vector2(2, 0);
    public bool isTurnedLeft;
    public int multiplySpeed = 2;

    public bool grounded = true;
    public bool hasJumped = false;

    int hp;

    // Use this for initialization
    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
        hp = gameObject.GetComponent<HealthController>().hp;

    }

    // Update is called once per frame
    void Update()
    {
        bool shoot = Input.GetButtonDown("Jump");
        shoot |= Input.GetButtonDown("Fire1");


        if (shoot)
        {
            Shooting weapon = GetComponent<Shooting>();
            if (weapon != null)
            {
                weapon.Attack(false);
            }
        }

        // Movement
        if (!grounded && rb.velocity.y == 0)
        {
            grounded = true;
        }

        if (Input.GetKeyDown("up") && grounded == true)
        {
            hasJumped = true;
        }

        if (Input.GetKey("right"))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
            if (isTurnedLeft)
            {
                isTurnedLeft = false;
                transform.eulerAngles = new Vector3(0, 0, 0);

            }
            if (Input.GetKey("right") && Input.GetKey("z"))
            {
                transform.Translate(Vector3.right * multiplySpeed * Time.deltaTime);
            }

        }

        if (Input.GetKey("left"))
        {
            isTurnedLeft = true;

            transform.Translate(Vector3.right * Time.deltaTime);
        }

        if (isTurnedLeft)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);

        }
        if (Input.GetKey("left") && Input.GetKey("z"))
        {
            transform.Translate(Vector3.right * multiplySpeed * Time.deltaTime);
        }

    }

    void FixedUpdate()
    {
        if (hasJumped)
        {
            rb.AddForce(transform.up * force);
            grounded = false;
            hasJumped = false;
        }

    }




    void OnCollisionEnter2D(Collision2D collision)
    {
        bool damagePlayer = false;

        // Collision with enemy
        EnemyController enemy = collision.gameObject.GetComponent<EnemyController>();
        if (enemy != null)
        {
            // Kill the enemy
            Destroy(collision.gameObject);
            damagePlayer = true;
        }

        // Damage the player
        if (damagePlayer)
        {
            gameObject.GetComponent<HealthController>().Damage(10);
            
        }
    }

}
