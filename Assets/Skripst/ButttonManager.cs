using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    //public static int Numbers;      � �� ���� ����� ���,�� ����� ���� �����
    //public int number;

    //void Start()
    //{
    //    number = GetComponent<int>();
    //}
    //void Update()
    //{
    //    Numbers = number;
    //}
    public void Play()//������� �� �������� ����� ����
    {
       
        SceneManager.LoadScene("Game");
    }
    public void Exit()//�����(�� ��������)
    {
        Application.Quit();
    }
}
