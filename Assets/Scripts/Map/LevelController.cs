using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [Header("Elements")]
    public TMP_Text text;
    public Button button;

    internal void Awake()
    {
        button.interactable = false;

        button.onClick.AddListener(OnClick);
    }

    public void Unlock()
    {
        button.interactable = true;
    }

    public void SetNumber(int number)
    { 
        text.text = number.ToString();
    }

    private void OnClick()
    {
        int levelNumber = int.Parse(text.text);
        PlayerPrefs.SetInt("Nivel Actual", levelNumber);
        SceneManager.LoadScene("Minijuego");
    }
}
