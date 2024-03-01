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
    public void CheckGuess()//�������� ������ � ���
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

        for (int i = 0; i < 4; i++)//�������� ��������� �����
        {
            int a = guessArray[i];
            a = a - 48;//�������� 48 ��-�� �������� �� �������,��� 1=49
            int b = secretNumber[i];

            if (a == b)//���������� guessArray � secretNumber �����������
            {
                bulls++;
            }
            guessArray[i] = guessArray[i] - 48;//�������� 48 ��-�� �������� �� �������,��� 1=49
            bool hasCommonElement = guessArray.Intersect(secretNumber).Any();//���������� ����� Intersect ��� ���������� ����������� 2 ��������,
                                                                             //� ����� ����� Any, ����� ���������, ���� �� � ���������� ���� �� ���� �������
            if (hasCommonElement)
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

