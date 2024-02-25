using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScreenController : MonoBehaviour
{
    [Header("Buttons")]
    public Button PlayButton;

    public Button NewGameButton;
    public Button ContinueButton;
    // public Button MinigamesButton;
    public Button ExitPlayPopUpButton;

    public Button OptionsButton;

    public Button ExitOptionsPopUpButton;
    public Button PersonalizarButton;
    public Button SettingsButton;

    [Header("PopUps")]
    public GameObject PlayPopUp;
    public GameObject OptionsPopUp;

    // Start is called before the first frame update
    void Start()
    {
        PlayButton.onClick.AddListener(OpenPlayPopUp);
        OptionsButton.onClick.AddListener(OpenOptionsPopUp);

        ExitPlayPopUpButton.onClick.AddListener(ClosePlayPopUp);
        ExitOptionsPopUpButton.onClick.AddListener(CloseOptionsPopUp);

        NewGameButton.onClick.AddListener(NewGame);
        ContinueButton.onClick.AddListener(Continue);
        // MinigamesButton.onClick.AddListener(Minigames);

        PersonalizarButton.onClick.AddListener(Personalizar);
        SettingsButton.onClick.AddListener(Settings);
        
        PlayPopUp.SetActive(false);
        OptionsPopUp.SetActive(false);
    }

    private void OpenPlayPopUp()
    {
        PlayPopUp.SetActive(true);
    }

    private void ClosePlayPopUp()
    {
        PlayPopUp.SetActive(false);
    }

    private void OpenOptionsPopUp()
    {
        OptionsPopUp.SetActive(true);
    }
    private void CloseOptionsPopUp()
    {
        OptionsPopUp.SetActive(false);
    }

    private void NewGame()
    {
        PlayerPrefs.SetInt("Niveles superados", 0);
        SceneManager.LoadScene("Cinematica");
    }

    private void Continue()
    {
        // TODO: Añadir código de carga de datos
        SceneManager.LoadScene("Inicio");
    }

    private void Personalizar()
    {
        SceneManager.LoadScene("Selection");
    }

    private void Settings()
    {
        SceneManager.LoadScene("Setting");
    }
}
