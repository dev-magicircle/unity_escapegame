using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//열쇠
public class KeyItem : MonoBehaviour
{
  //마우스를 클릭하면
  void OnMouseUp(){
      GameVariables.keycount+=2;//키 값을 1올림
      Destroy(gameObject);//키 없앰
    }
  }

