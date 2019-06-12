using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollController : MonoBehaviour
{
    // Start is called before the first frame update
    public float scrollSpeed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localPosition = new Vector2(gameObject.transform.localPosition.x + -scrollSpeed * Time.deltaTime, gameObject.transform.localPosition.y);   
    }
}
