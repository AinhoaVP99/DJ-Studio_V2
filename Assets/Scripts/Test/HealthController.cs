using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [Header ("Vida")]
    public List<Image> hearts;
    public Button addHeartButton;
    public Button removeHeartButton;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private int health = 3;

    void Awake()
    {
        health = hearts.Count;
        UpdateHealth();

        // Al pulsar el boton "AddHeartButton" llamamos a la funcion "AddHeart"
        addHeartButton.onClick.AddListener(AddHeart);

        // Al pulsar el boton "RemoveHeartButton" llamamos a la funcion "RemoveHeart"
        removeHeartButton.onClick.AddListener(RemoveHeart);
    }

    private void UpdateHealth()
    {
        // Repite desde 0 hasta la cantidad de imagenes de corazon, de uno en uno
        for (int iteracion = 0; iteracion < hearts.Count; iteracion++)
        {
            // Iteración es la posicion de la imagen de corazon en la lista (recordemos que empieza en 0)
            if (iteracion < health)
            {
                // Si es menor que los puntos de vida rellenamos el corazon.
                hearts[iteracion].sprite = fullHeart;
            }
            else
            {
                // Si es mayor o igual, lo vaciamos
                hearts[iteracion].sprite = emptyHeart;
            }
        }
    }

    private void AddHeart()
    {
        // El nuevo valor deseado es la vida mas uno
        var newValue = health + 1;

        if (newValue > hearts.Count)
        {
            // Si se pasa del tamaño de la lista de corazones paramos (Es demasiada vida)
            return;
        }

        health = newValue;

        // Actualizamos la parte grafica
        UpdateHealth();
    }

    private void RemoveHeart()
    {
        // El nuevo valor deseado es la vida menos uno
        var newValue = health - 1;

        if (newValue < 0)
        {
            // Si es menos de cero paramos (No hay vida negativa)

            // TODO: AÑADIR AQUI LO QUE QUIERAS QUE PASE CUANDO TE QUEDAS SIN VIDA

            return;
        }

        health = newValue;

        // Actualizamos la parte grafica
        UpdateHealth();
    }
}
