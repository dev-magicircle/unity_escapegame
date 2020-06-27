using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//씬이동
public class OnTriggerLoadLevel : MonoBehaviour
{
    public GameObject guiObject;//ui 오브젝트
    public string levelToLoad;//변화시키는 씬이름

    //처음에 ui를 안 보이게 설정
    void Start()
    {
        guiObject.SetActive(false);
    }

    //오브젝트가 플레이어에 닿았을 때
    void OnTriggerStay(Collider other){
      //닿은 오브젝트가 플레이어일 때
      if(other.gameObject.tag=="Player")
      {
        //ui화면을 보여줌
        guiObject.SetActive(true);
        //"Use"키를 눌렀을 때(본 게임에서 E키를 눌렀을 때)
        if(Input.GetButtonDown("Use"))
        {
          //화면 전환
          StartCoroutine(LoadScene());
        }
      }
    }
    //전환하는 화면 설정
    IEnumerator LoadScene(){
      yield return new WaitForSeconds(1.5f);//중간에 시간 텀을 줌
      SceneManager.LoadScene(levelToLoad);//SceneManager로 씬을 불러옴
    }

    //오브젝트에 플레이어가 닿지 않았을 때
    void OnTriggerExit(Collider other)
    {
      if(other.gameObject.tag=="Player")
      {
        guiObject.SetActive(false);
      }
    }
}
