using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    
   
    public float speed;
    public void Start()
    {
        
    }

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {


        
        GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;

    }
}
