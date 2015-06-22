using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour
{

    Animator anim;
    float ver = 0.0f;
    float hor = 0.0f;
    float shoot = 0.0f;


    // Use this for initialization
    void Start()
    {
        this.anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        if (ver > 0)
        {
            anim.SetFloat("Jumping", ver);
            ver = 0.0f;
            hor = 0.0f;

        }

        if (ver < 0)
        {
            anim.SetFloat("Jumping", ver);
            ver = 0.0f;
            hor = 0.0f;
        }

        if (hor > 0)
        {
            anim.SetFloat("Walking", hor);
            hor = 0.0f;
            ver = 0.0f;

        }

        if (hor < 0)
        {
            anim.SetFloat("Walking", hor);
            hor = 0.0f;
            ver = 0.0f;
        }

        if (Input.GetButtonDown("Jump"))
        {
            shoot = 0.5f;
            anim.SetFloat("Shooting", shoot);
        }

        if (Input.GetButtonUp("Jump"))
        {
            shoot = 0.0f;
            anim.SetFloat("Shooting", shoot);
        }
    }
}
