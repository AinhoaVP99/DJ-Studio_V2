using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Permite llamar escenas

public class MenuSeleccion : MonoBehaviour
{
    public GameObject[] playerObjects; //Array personajes (0,1,2,...))

    public int selectedCharacter = 0; //Número del personaje seleccionado

    public string gameScene = "Personalizacion"; //Nombre de escena

    private string selectedCharacterDataName = "SelectedCharacter";

    // Start is called before the first frame update
    void Start()
    {
        HideAllCharacters();//Ejecuta el borrado de los personajes al inicio
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void HideAllCharacters()// Borra personajes
    {
        foreach (GameObject g in playerObjects) //Deasctiva todos los personajes 
        {
            g.SetActive(false);
        }

        if (selectedCharacter == 0)
        {
            playerObjects[selectedCharacter].SetActive(true);
        }
    }

    public void NextCharacter() //activa el siguiente personajes desde el botón
    {
        playerObjects[selectedCharacter].SetActive(false); //Oculta el personaje actual
        selectedCharacter++; //suma uno al personaje

        if (selectedCharacter >= playerObjects.Length)//si el valor del personaje es mayor que la longitud del array ...
        {
            selectedCharacter = 0; //lo vuelve a poner en 0
        }

        playerObjects[selectedCharacter].SetActive(true); //Activa el personaje
    }
    public void PreviousCharacter() //activa el anterior personajes desde el botón
    {
        playerObjects[selectedCharacter].SetActive(false); //Oculta el personaje actual
        selectedCharacter--; //resta uno al personaje

        if (selectedCharacter < 0)//si el valor del personaje es menor que 0 ...
        {
            selectedCharacter = playerObjects.Length - 1; //el valor del personaje se vuelve la longitud del array -1
        }

        playerObjects[selectedCharacter].SetActive(true); //Activa el personaje
    }
    public void StartGame()
    {
        PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter); //almacena que personaje pasa a la zona de juego
    }

}
