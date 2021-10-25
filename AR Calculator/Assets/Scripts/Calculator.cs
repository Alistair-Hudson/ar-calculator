using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calculator : MonoBehaviour
{
    [SerializeField]TMP_Text display = null;

    Queue<string> storedEquation = new Queue<string>();
    

    private void Start()
    {
        display.text = "";
    }

    public void NumberInput(int number)
    {
        display.text += number.ToString();
    }

    public void DecimalPoint()
    {
        if("" == display.text)
        {
            display.text = "0.";
        }
        else if (!display.text.Contains("."))
        {
            display.text += ".";
        }
    }
  
    public void Add()
    {
        storedEquation.Enqueue(display.text);
        display.text = "";
        storedEquation.Enqueue("+");
    }

    public void Multiply()
    {
        storedEquation.Enqueue(display.text);
        display.text = "";
        storedEquation.Enqueue("*");
    }

    public void Divide()
    {
        storedEquation.Enqueue(display.text);
        display.text = "";
        storedEquation.Enqueue("/");
    }

    public void Subtract()
    {
        if ("" == display.text)
        {
            display.text = "-";
        }
        else
        {
            storedEquation.Enqueue(display.text);
            display.text = "";
            storedEquation.Enqueue("-");
        }
    }

    public void Equals()
    {
        storedEquation.Enqueue(display.text);
        float total = float.Parse(storedEquation.Dequeue());
        while (0 < storedEquation.Count)
        {
            string str = storedEquation.Dequeue();
            if ("+" == str)
            {
                total += float.Parse(storedEquation.Dequeue());
            }
            else if ("-" == str)
            {
                total -= float.Parse(storedEquation.Dequeue());
            }
            else if ("*" == str)
            {
                total *= float.Parse(storedEquation.Dequeue());
            }
            else if ("/" == str)
            {
                total /= float.Parse(storedEquation.Dequeue());
            }
        }
        display.text = total.ToString();
    }

    public void Clear()
    {
        display.text = "";
        storedEquation.Clear();
    }
}
