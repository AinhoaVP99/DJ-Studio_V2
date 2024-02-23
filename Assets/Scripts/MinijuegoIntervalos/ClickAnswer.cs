using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickAnswer : MonoBehaviour
{
    public GameObject opcion; //llama al objeto

    public void Update()
    {
       
    }
    public void ClickonAnswer()
   {
       // opcion = GameObject.Find("intervalo(Clone)"); //busca el objeto con el nombre entre "
      
        opcion = GameObject.Find("IntervaloIconComp1(Clone)");
    //    opcion = GameObject.Find("IntervaloIconComp1(Clone)");
      //  opcion = GameObject.Find("IntervaloIconComp2(Clone)");
        Destroy(opcion);
        Debug.Log("destruir");
   }
    public void ClickonAnswer2()
    {
        opcion = GameObject.Find("IntervaloIconComp2(Clone)");
        Destroy(opcion);
        Debug.Log("destruir");
    }
        //private void OnTriggerEnter(Collider other)
        //{
        //    Destroy(gameObject);
        // }
    }
