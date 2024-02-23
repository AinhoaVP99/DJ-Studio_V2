using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //Necesario para que funcione el canva
public class PulsarObjeto : MonoBehaviour
{
    public string sceneName;
    public Canvas canvasSuperposicion;
    public AudioSource audioSource;

    private void OnMouseDown()
    {

        SceneManager.LoadScene(sceneName); //Al clicar cambia de escena

    }
    private void OnMouseOver()
    {

        canvasSuperposicion.gameObject.SetActive(true); //Al pasar el raton por encima se activa
        audioSource.Play();
    }
    private void OnMouseExit()
    {
        canvasSuperposicion.gameObject.SetActive(false); //Al salir el raton se desactiva
    }
}