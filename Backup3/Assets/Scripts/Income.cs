using UnityEngine;
using System.Collections;

public class Income : MonoBehaviour
{
    public static int income;
    public float tickRate;

    void Start()
    {
        InvokeRepeating("generateIncome", 0, tickRate);
    }

    void Update()
    {
    }
    
    void generateIncome()
    {
        income += GameObject.FindGameObjectsWithTag("mine").Length * 1;
    }

    void OnGUI()
    {
        string money = "Money: " + Income.income.ToString() + "$";
        GUI.Label(new Rect(10f, 7f, 100f, 25f), money);
    }
     
}
