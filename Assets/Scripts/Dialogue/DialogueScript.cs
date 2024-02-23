using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class DialogueScript : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public DialogueLine[] lines;
    public CharacterImage[] images;
    public Sprite[] characterSprites;
    public float TextSpeed = 0.1f;
    int index;
    
    void Start()
    {
        dialogueText.text = string.Empty;

        // Repite algo por cada elemento de la lista imagenes
        foreach (CharacterImage elemento in images) 
        {
            // Desactivamos el elemento que contiene a la imagen
            elemento.image.gameObject.SetActive(false);

            if (elemento.character == Characters.Erik)
            {
                var selectedCharacter = PlayerPrefs.GetInt("selectedOption", 0);

                elemento.image.sprite = characterSprites[selectedCharacter];
            }
        }

        StartDialogue();
    }

    private void ShowCharacterSpeaking(Characters character)
    {
        // Repite algo por cada elemento de la lista imagenes
        foreach (CharacterImage elemento in images)
        {
            if (elemento.character == character)
            {
                // Si es el que está hablando lo mostramos y lo ponemos sin transparencia
                elemento.image.gameObject.SetActive(true);
                elemento.image.color = Color.white;

                elemento.image.transform.localScale = Vector3.one;
            }
            else
            {
                // Si es cualquier otro lo ponemos semi-transparente
                var color = Color.white;
                color.a = 0.5f;
                elemento.image.color = color;

                elemento.image.transform.localScale = Vector3.one * 0.9f;
            }
        }
    }

    void Update()
    {
        // Detectamos cuando se pulsa el boton izquierdo del raton
        if (Input.GetMouseButtonDown(0))
        {
            if (dialogueText.text == lines[index].text)
            {
                // Si se repite el texto, pasamos a la siguiente linea
                NextLine();
            }
            else
            {
                // Si no, paramos la animación y ponemos el texto completo
                StopAllCoroutines();
                dialogueText.text = lines[index].text;
            }
        }
    }

    public void StartDialogue()
    {
        index = -1;
        NextLine();
    }

    IEnumerator WriteLine()
    {
        // Por cada caracter de la linea
        foreach (char letter in lines[index].text.ToCharArray())
        {
            // Añades el caracter a el texto
            dialogueText.text += letter;
            // Esperas "TextSpeed" segundos
            yield return new WaitForSeconds(TextSpeed);
        }
    }

    public void NextLine()
    {
        // Si quedan lineas
        if(index < lines.Length - 1)
        {
            // Cambiar a la siguiente linea
            index++;
            // Limpiar el texto en pantalla
            dialogueText.text = string.Empty;
            // Mostramos al personaje de esa linea
            ShowCharacterSpeaking(lines[index].character);
            // Empezar la animación de escritura
            StartCoroutine(WriteLine());
        }
        else
        {
            // Si no quedan lineas ocultar el texto y personajes
            gameObject.SetActive(false);
            foreach (CharacterImage image in images)
            {
                image.image.gameObject.SetActive(false);
            }

            SceneManager.LoadScene("inicio");
        }
    }
}

[Serializable]
public class DialogueLine
{
    public Characters character;
    public string text;
}

[Serializable]
public class CharacterImage
{
    public Characters character;
    public Image image;
}

[Serializable]
public enum Characters
{
    Garrus,
    Erik
}