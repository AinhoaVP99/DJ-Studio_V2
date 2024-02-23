using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Cargamos librer�a de escenas

public class GameControl : MonoBehaviour
{
    public GameObject[] characters; //Se almacenan varios valores (array). Prefabs de personajes
    public Transform playerStartPosition; //Posici�n inicial del personaje
    public string menuScene = "Personalizacion";//Nombre de la escena de selecci�n
    public string selectedCharacterDataName = "SelectedCharacter"; //nombre del personaje seleccionado
    int selectedCharacter; //Numero del personaje en el array
    public GameObject playerObject; //Referencia del personaje

    // Start is called before the first frame update
    void Start()
    {
        selectedCharacter = PlayerPrefs.GetInt(selectedCharacterDataName, 0); //Recuperamos la posici�n del personaje seleccionado
        playerObject = Instantiate(characters[selectedCharacter], playerStartPosition.position, characters[selectedCharacter].transform.rotation);//Instancia el personaje seleccionado en una posici�n
    }

    // Update is called once per frame
    void Update()
    {
       
    }
   
}
