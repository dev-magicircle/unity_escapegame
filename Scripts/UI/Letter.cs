using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//메모
public class Letter : MonoBehaviour
{
    public GameObject guiObject;//플레이어 가리킬 메모 오브젝트
    //처음에 시작할 땐 메모 오브젝트가 안 보이게 함
    void Start()
    {
      guiObject.SetActive(false);
    }
    //메모를 클릭하면
    void OnMouseDown(){
        guiObject.SetActive(true);
    }
    //메모를 클릭하지 않는다면
    void OnMouseUp(){
        guiObject.SetActive(false);
    }
}

