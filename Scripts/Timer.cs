using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
  public string levelToLoad;
  private float timer=800f;
  private Text timerSeconds;
    void Start()
    {
        timerSeconds=GetComponent<Text>();
    }

    void Update()
    {
        timer-=Time.deltaTime;
        Debug.Log(timer);
        timerSeconds.text=timer.ToString("f1");
        if(timer<=0)
        {
          Application.LoadLevel(levelToLoad);
        }
    }
}
