using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowGirlMovement : MonoBehaviour
{
    public float Force;
    public Rigidbody2D playerRb;
    public float gravityModifier;
    public bool Isonground;
    public Animator CowGirl;


    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        CowGirl = GetComponent<Animator>();
        Physics2D.gravity *= gravityModifier;

    }
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && Isonground)
        {
            playerRb.AddForce(Vector2.up * Force, ForceMode2D.Impulse);

            Isonground = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && Isonground)
        {
            CowGirl.SetTrigger("CowGirl_jumptrigg");
            playerRb.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
            Isonground = false;

        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Isonground = true;
            CowGirl.SetTrigger("CowGirl_StartTrigg");
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectables"))
        {
            Destroy(other.gameObject);
            Collactables.Coinamount += 1;
        }
    }
}
