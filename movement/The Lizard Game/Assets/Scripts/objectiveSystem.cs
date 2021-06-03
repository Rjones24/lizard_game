using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectiveSystem : MonoBehaviour
{

    public int currentTask = 1;
    private string task;
    public static int applesEaten=0;
    public static int MeatEaten=0;
    public static int applesRemaining = 25;
    public static int poachersKilled=0;
    public static int poachersRemaining = 12;
    public static int MeatRemaining = 15;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        switch (currentTask)
        {
            case 1:
                task1();

                break;

            case 2:
                task2();
                break;

            case 3:
                task3();

                break;

            case 4:
                task4();
                break;

            case 5:
                task5();

                break;

            default:
              
                break;
        }
    }

    public void task1()
    {
        task = "eat 2 apples non non nom";

        if (applesEaten >= 2)
        {
            currentTask = 2;
            applesEaten = 0;
            poachersKilled = 0;
            MeatEaten = 0;
        }
    
    }
    public void task2()
    {
        task = "kill 1 lizard poacher";
        if (poachersKilled >= 1)
        {
            currentTask = 3;
            applesEaten = 0;
            poachersKilled = 0;
            MeatEaten = 0;
        }
    }
    public void task3()
    {
        task = "eat 5 cooked meats yum yum";
        if (MeatEaten >= 5)
        {
            currentTask = 4;
            applesEaten = 0;
            poachersKilled = 0;
            MeatEaten = 0;
        }
    }
    public void task4()
    { 
        task = "eat 5 apples                             " + applesEaten+
            " kill 3 lizard poachers                   " + poachersKilled+
            " eat 10 cooked meats "+ MeatEaten;
        if ((MeatEaten >= 10) && (applesEaten >= 5) && (poachersKilled >= 3))
        {
            currentTask = 5;
        }
    }
    public void task5()
    {
        task = "eat all apples                             " +applesRemaining+
               " kill all lizard poachers                   "+poachersRemaining+
               "eat all cooked meats" +MeatRemaining;

        if ((applesRemaining <= 0) && (poachersRemaining <= 0))
        {
            objectiveSystem.applesEaten += 1;
        }
       
    }

    private void OnGUI()
    {
        GUI.skin.box.wordWrap = true;
        GUI.skin.box.fontSize = 20;
        GUI.Box(new Rect(100, 500, 400, 150), task); 
    }
    
}
