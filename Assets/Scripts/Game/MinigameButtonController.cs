using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLevelToMap()
    {
        var nivel_actual = PlayerPrefs.GetInt("Nivel Actual");
        var niveles_superados = PlayerPrefs.GetInt("Niveles superados");

        if (nivel_actual == niveles_superados + 1)
        {
            PlayerPrefs.SetInt("Niveles superados", niveles_superados + 1);
        }
    }
}
