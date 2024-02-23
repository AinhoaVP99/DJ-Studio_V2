using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour
{
    public void Salida()
    {
        Application.Quit(); // Salimos de la aplicacionmmmmmm
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit(); // Salimos de la aplicacion
        }
    }

}
