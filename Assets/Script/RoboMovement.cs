using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboMovement : MonoBehaviour
{
    public float Force;
    public Rigidbody2D playerRb;
    public float gravityModifier;
    public bool Isonground;
    public Animator Robo;


    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Robo = GetComponent<Animator>();
        Physics2D.gravity *= gravityModifier;

    }
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && Isonground)
        {
            playerRb.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
            Robo.SetTrigger("Robo_JumpTrigg");

            Isonground = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && Isonground)
        {
            Robo.SetTrigger("Robo_JumpTrigg");
            playerRb.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
            Isonground = false;

        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Isonground = true;
            Robo.SetTrigger("Robo_StartTrigg");
        }
    }
  
}
