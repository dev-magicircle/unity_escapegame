using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowWords : MonoBehaviour
{
    public GameObject guiObject;//플레이어 가리킬 오브젝트
    
    void Start()
    {
        guiObject.SetActive(false);
    }
    //플레이어가 가까이오면
    void OnTriggerStay(Collider other){
      if(other.gameObject.tag=="Player")
      {
        guiObject.SetActive(true);
      }
    }
    //플레이어가 범위 밖이라면
    void OnTriggerExit(Collider other)
    {
      if(other.gameObject.tag=="Player")
      {
        guiObject.SetActive(false);
      }
    }
}

