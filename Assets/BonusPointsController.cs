using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusPointsController : MonoBehaviour
{
    private AudioSource popSound;
    void Start()
    {
        popSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Physics2D.IgnoreCollision(collider, gameObject.GetComponent<CapsuleCollider2D>());
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            ScoreController.score += 100;
            popSound.Play();
            Destroy(gameObject, 1.5f);
        }
    }
}
