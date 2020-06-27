using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//키가 있으면 문을 연다. 
public class KeyOpen : MonoBehaviour
{
  //마우스 클릭하면
  void OnMouseUp(){
    //키가 존재한다면
    if(GameVariables.keycount>0){
      GameVariables.keycount--;//키 값을 하나 감소시킴
      Destroy (gameObject);//문 오브젝트 없앰
    }
  }
}
