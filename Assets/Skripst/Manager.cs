using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    //public static int Numbers;      я не знаю зачем оно,но пусть пока будет
    //public int number;

    //void Start()
    //{
    //    number = GetComponent<int>();
    //}
    //void Update()
    //{
    //    Numbers = number;
    //}
    public void Play()//переход на основную сцену игры
    {
       
        SceneManager.LoadScene("Game");
    }
    public void Exit()//выход(ну наверное)
    {
        Application.Quit();
    }
}
