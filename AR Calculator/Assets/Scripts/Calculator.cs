using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calculator : MonoBehaviour
{
    [SerializeField]TMP_Text display = null;


    public void NumberInput(int number)
    {
        display.text += number.ToString();
    }
  
    public void SymbolButton(string symbol)
    {
        display.text += symbol;
    }

    public void Equals()
    {

    }
}
