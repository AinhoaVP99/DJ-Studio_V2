using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName); //Cambio de escena 
    }
    public void Salida()
    {
        Application.Quit(); //Salimos de la aplicación
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //Al pulsar las teclas escape
        {
            Application.Quit(); //Salimos de la aplicación
        }
    }

    public void AbrirUrl(string url)
    {
        Application.OpenURL(url);
    }
}
