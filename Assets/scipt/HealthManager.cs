using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    const float MaxHealth = 100f;
    float health;
    // Start is called before the first frame update
    void Start()
    {
        health = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    void Die()
    {
        GetComponent<playermovment>().enabled = false;
    }
    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }
}
