using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public float healthBonus = 10f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            collision.gameObject.GetComponent<HealthManager>().Heal(healthBonus);
        Destroy(gameObject);
    }
    
    
}
