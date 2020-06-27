using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerLoadLevelSen : MonoBehaviour
{
    public GameObject guiObject;//플레이어 가리킬 오브젝트
    public string levelToLoad;//변화시키는 씬이름
    public string openscene;//다 열었을 때 씬 이름
    public Animator transitionAnim;//애니메이션
    // Start is called before the first frame update
    void Start()
    {
        guiObject.SetActive(false);
    }
    void OnTriggerStay(Collider other){
      if(other.gameObject.tag=="Player")
      {
        SwitchGate.Sen=true;
        guiObject.SetActive(true);
        if(Input.GetButtonDown("Use"))
        {
          Debug.Log(SwitchGate.Reve+""+SwitchGate.Sen);
          if(SwitchGate.Reve==true)
          {
            StartCoroutine(OpenScene());// 두 방 다 갔다옴
          }
          else{
            StartCoroutine(LoadScene());// 현재 방만 갔다온 경우
          }
 
        }
      }
    }
    //원래 장면
    IEnumerator LoadScene(){
      yield return new WaitForSeconds(1.5f);
      SceneManager.LoadScene(levelToLoad);
    }
    //두 방 다 갔다왔을 때 
    IEnumerator OpenScene(){
      yield return new WaitForSeconds(1.5f);
      SceneManager.LoadScene(openscene);
    }
    void OnTriggerExit(Collider other)
    {
      if(other.gameObject.tag=="Player")
      {
        guiObject.SetActive(false);
      }
    }
}
