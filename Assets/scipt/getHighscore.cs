using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getHighscore : MonoBehaviour
{
    public Text highscore;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
        highscore.text = PlayerPrefs.GetInt("highscore").ToString();
    }
}
