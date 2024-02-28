using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
using System.Linq;
using static UnityEngine.Rendering.DebugUI;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    //[SerializeField] TextMeshProUGUI FourNumbers;

    [SerializeField] TMP_InputField inputField;
    [SerializeField] TextMeshProUGUI outputText;

    int[] secretNumber = new int[4];

    public void Start()
    {
        secretNumber = GenerateSecretNumber();
    }
    
    public void CheckBtn()
    {
        CheckGuess();
    }
    public void CheckGuess()//передача данных в код
    {
        //inputField.enabled = true;
        string guess = inputField.text;
        int[] guessArray = new int[4];

        for (int i = 0; i < guess.Length; i++)
        {
            guessArray[i] = guess[i];
        }

        int bulls = 0;
        int cows = 0;

        for (int i = 0; i < 4; i++)//проверка положения цифры
        {
            int a = guessArray[i];
            int b = secretNumber[i];

            if (a -48 == b)
            {
                bulls++;
            }
            else if(secretNumber.Contains(guessArray[i]))
            {
                cows++;
            }
        }

        if (bulls == 4)
        {
            outputText.text = "вы выиграли";
        }
        else
        {
            outputText.text = "быки: " + bulls + " коровы: " + cows;
        }
    }

    private int[] GenerateSecretNumber()//делаем 4 цифорки для массива
    {
        System.Random random = new System.Random();
        int[] number = new int[4];
        for (int i = 0; i < 4; i++)
        {
            int num = random.Next(0, 10);
            while (Array.IndexOf(number, num) != -1)
            {
                num = random.Next(0, 10);
            }
            number[i] = num;
        }
        return number;
    }
}

