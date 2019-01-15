using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hantei : MonoBehaviour
{

  //トリガー状態のオブジェクトに衝突した瞬間に呼ばれます
  void OnTriggerEnter(Collider other)
  {
    if(other.name == "Player(Clone)"){
      Debug.Log("Trigger Enter" + other.name);
      SceneManager.LoadScene ("Crear");
    }
  }

  //トリガー状態のオブジェクトと衝突している間に呼ばれ続けます
  void OnTriggerStay(Collider other)
  {
      Debug.Log("Trigger Stay" + other.name);
      Debug.Log(other.name + "= " + other.name.GetType().FullName);
  }

  /*//トリガー状態のオブジェクトとの衝突から離れた瞬間に呼ばれます
  void OnTriggerExit(Collider other)
  {
      Debug.Log("Trigger Exit" + other.name);
  }*/
}
