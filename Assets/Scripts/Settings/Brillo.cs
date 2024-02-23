using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brillo : MonoBehaviour
{
    public Slider slider_brillo;
    public float sliderValueB;
    public Image panelBrillo;

    // Start is called before the first frame update
    void Start()
    {
        slider_brillo.value = PlayerPrefs.GetFloat("brillo", 0.5f);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, slider_brillo.value);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeSlider(float valor)
    {
        sliderValueB = valor;
        PlayerPrefs.SetFloat("brillo", sliderValueB);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, slider_brillo.value);
    }
}
