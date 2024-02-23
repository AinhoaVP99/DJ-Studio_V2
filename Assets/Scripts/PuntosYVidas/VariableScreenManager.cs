using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VariableScreenManager : MonoBehaviour
{
    [Header("Dinero")]
    public TMP_Text moneyText;
    public Button addMoneyButton;
    public Button removeMoneyButton;

    private int money = 0;

    void Awake()
    {
        money = 30;
        UpdateMoney();

        // Al pulsar el bot�n "AddMoneyButton" llamamos a la funcion "AddMoney"
        addMoneyButton.onClick.AddListener(AddMoney);

        // Al pulsar el bot�n "RemoveMoneyButton" llamamos a la funcion "RemoveMoney"
      //  removeMoneyButton.onClick.AddListener(RemoveMoney);
    }

    private void AddMoney()
    {
        // A�adimos uno a la cantidad de dinero
        money++;

        // Actualizamos el texto
        UpdateMoney();

        if (money == 31)
        {
            Destroy(addMoneyButton);
        }
    }
    

    //private void RemoveMoney()
    //{
      //  if (money <= 0)
        //{
            // Si vamos a quedarnos en dinero negativo paramos
          //  return;
        //}

        // Quitamos uno a la cantidad de dinero
        //money--;

        // Actualizamos el texto
        //UpdateMoney();
    //}

    private void UpdateMoney()
    {
        // Asignamos el valor de dinero al texto "MoneyText"
        moneyText.text = money.ToString();
    }
}

