using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //[SerializeField] TextMeshProUGUI FourNumbers;

    [SerializeField] public TextMeshProUGUI inputField;
    [SerializeField] TextMeshProUGUI outputText;
    

     private int[] secretNumber;

    private void Start()
    {
       secretNumber = GenerateSecretNumber();
    }

    public void CheckBtn()
    {
         CheckGuess();
    }
    public void CheckGuess()//�������� ������ � ���
    {
        string guess = inputField.ToString();
        int[] guessArray = new int[4];

        for (int i = 0; i < 4; i++)
        {
            guessArray[i] = int.Parse(guess[i].ToString());
        }

        int bulls = 0;
        int cows = 0;

        for (int i = 0; i < 4; i++)//�������� ��������� �����
        {
            if (guessArray[i] == secretNumber[i])
            {
                bulls++;
            }
            else if (Array.IndexOf(secretNumber, guessArray[i]) != -1)
            {
                cows++;
            }
        }

        if (bulls == 4)
        {
            outputText.text = "�� ��������";
        }
        else
        {
            outputText.text = "����: " + bulls + " ������: " + cows;
        }
    }

    private int[] GenerateSecretNumber()//������ 4 ������� ��� �������
    {
        int[] number = new int[4];
        for (int i = 0; i < 4; i++)
        {
            number[i] = UnityEngine.Random.Range(0, 10);
        }
        return number;
    }
}

