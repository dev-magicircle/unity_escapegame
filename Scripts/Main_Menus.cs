using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menus : MonoBehaviour
{
  public void Playgame()
  {
    SceneManager.LoadScene("Firstdream");
  }

  public void Quitgame()
  {
    Application.Quit();
  }

    /*public void GoSetting()
  {
    SceneManager.LoadScene("SampleScene");
  }
  public void BackSetting()
  {
    SceneManager.LoadScene("Start");
  }*/
}
