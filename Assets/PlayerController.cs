using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;
    public float flapStrength;
    public float xMovementStrength;
    public Vector2 maxVelocity;
    private Animator anim;
    private AudioSource deathSound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        deathSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.y >= maxVelocity.y)
        {
            rb.velocity = new Vector2(rb.velocity.x, maxVelocity.y);
        }
        if (rb.velocity.x >= maxVelocity.x)
        {
            rb.velocity = new Vector2(maxVelocity.x, rb.velocity.y);
        }
        if (rb.velocity.x <= (maxVelocity.x * -1))
        {
            rb.velocity = new Vector2(maxVelocity.x * -1, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * flapStrength, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector2.left * xMovementStrength, ForceMode2D.Force);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector2.right * xMovementStrength, ForceMode2D.Force);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        Debug.Log("Collided with: " + collider.gameObject.tag);
        if (collider.gameObject.tag == "Star")
        {
            anim.SetBool("isDead", true);
            deathSound.Play();
        }
    }
}
