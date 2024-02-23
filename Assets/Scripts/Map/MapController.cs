using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapController : MonoBehaviour
{
    [Header("Image")]
    public Image userImage = null;
    public List<Sprite> sprites = new List<Sprite>();

    [Header("Levels")]
    public List<LevelController> levels = new();

    void Start()
    {
        for (int i = 0; i < levels.Count; i++)
        {
            // Empezamos en 0, pero el primer elemento queremos que muestre 1
            levels[i].SetNumber(i+1);
        }

        var nivelesSuperados = PlayerPrefs.GetInt("Niveles superados");

        for (int i = 0;i <= nivelesSuperados; i++)
        {
            if (i < levels.Count)
            {
                levels[i].Unlock();
            }
        }

        var selectedUser = PlayerPrefs.GetInt("selectedOption", 0);
        userImage.sprite = sprites[selectedUser];
    }
}