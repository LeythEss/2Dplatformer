using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getHighscore : MonoBehaviour
{
    public Text score;
    public Text highscore;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        score.text = PlayerPrefs.GetInt("savedscore").ToString();
        highscore.text = PlayerPrefs.GetInt("highscore").ToString();
    }
}
