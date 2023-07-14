using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowBoyMovement : MonoBehaviour
{
    public float Force;
    public Rigidbody2D playerRb;
    public float gravityModifier;
    public bool Isonground;
    public Animator CowBoy;


    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        CowBoy = GetComponent<Animator>();
        Physics2D.gravity *= gravityModifier;

    }
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && Isonground)
        {
            playerRb.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
            CowBoy.SetTrigger("Cowboy_JumpTrigg");

            Isonground = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && Isonground)
        {
            CowBoy.SetTrigger("Cowboy_JumpTrigg");
            playerRb.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
            Isonground = false;

        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Isonground = true;
            CowBoy.SetTrigger("CowBoy_StartTrigg");
        }
    }
   
}
