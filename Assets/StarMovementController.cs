using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMovementController : MonoBehaviour
{
    // Start is called before the first frame update

    public float movespeed;
    Collider2D collider;
    private GameObject rightBoundary;
    private GameObject leftBoundary;
    void Start()
    {
        collider = GetComponent<CircleCollider2D>();
        rightBoundary = GameObject.Find("boundary_right");
        leftBoundary = GameObject.Find("boundary_left");
        Physics2D.IgnoreCollision(collider, rightBoundary.GetComponent<BoxCollider2D>());
        Physics2D.IgnoreCollision(collider, leftBoundary.GetComponent<BoxCollider2D>());

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localPosition = new Vector2(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y + movespeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("Collided with Player");
            movespeed = 0;
            gameObject.transform.localPosition = new Vector2(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y);
        }
        if (collider.gameObject.tag == "WorldBoundary")
        {
            movespeed = movespeed * -1;
        }
    }
}
