using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//특정한 곳에 다가가면 한번만 말이 나타남
public class ShowUI : MonoBehaviour
{
  public GameObject uiObject;//화면 
  
    //시작할 때는 비활성화
    void Start()
    {
      Debug.Log("start");
        uiObject.SetActive(false);
    }
    //플레이어와 만났을 때 이벤트 시작
    void OnTriggerEnter(Collider player)
    {
      if(player.gameObject.tag=="Player")
      {
        Debug.Log("meet"); 
        uiObject.SetActive(true);
        StartCoroutine("WaitForSec");
      }
    }

    //UI화면없앰
    IEnumerator WaitForSec()
    {
      yield return new WaitForSeconds(5);//5초대기
      Destroy(uiObject);
      Destroy(gameObject);
    }
}