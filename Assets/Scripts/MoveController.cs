using UnityEngine;
using System.Collections;

public class MoveController : MonoBehaviour
{
    public Vector2 speed = new Vector2(10, 10);
    public Vector2 direction = new Vector2(1, 0);

    public Vector2 movement;
    // Use this for initialization
    public void Start()
    {
         Vector2 speed = new Vector2(10, 10);

    }

    // Update is called once per frame
    public void Update()
    {
        movement = new Vector2(
              speed.x * direction.x,
              speed.y * direction.y);
    }
   public void FixedUpdate()
   {
        GetComponent<Rigidbody2D>().velocity = movement;
   }
}
