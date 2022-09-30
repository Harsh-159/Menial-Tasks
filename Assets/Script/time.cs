using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class time : MonoBehaviour
{
    // Start is called before the first frame update
    Text curTime;
    private float t;
    private float score;
    void Start()
    {
        if (!PlayerPrefs.HasKey("Highscore"))
        {
            PlayerPrefs.SetFloat("Highscore", 0f);
        }
        curTime = GetComponent<Text>();
        t = (int)Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        score =(int)Time.time - t;
        if (score > PlayerPrefs.GetFloat("Highscore"))
        {
            PlayerPrefs.SetFloat("Highscore", score);
        }
        curTime.text = "Score:" + score.ToString() + "\n"+"HighScore:"+PlayerPrefs.GetFloat("Highscore").ToString();
    }
}
