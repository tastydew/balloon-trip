using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkMovementController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject playerToFollow;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerToFollow != null)
            transform.position = new Vector2(playerToFollow.transform.position.x, transform.position.y);
    }
}
