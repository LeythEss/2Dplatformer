using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    int score;
    public Text scoretxt;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag== "coin")
        {
            score++;
            Destroy(collision.gameObject);
            scoretxt.text = score.ToString();
        }
        if(collision.gameObject.tag == "HiddenCoin")
        {
            score += 10;
            Destroy(collision.gameObject);
            scoretxt.text = score.ToString();
        }
    }
}
