using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_sharp : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    string[] cars;

    void Start()
    {
        cars = new string[] {"this game is about a man trying to solve the murder of his little sister", "youll be going to explore a haunted forest and his old hometown in Japan."};
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Horror();
        if (health == 100)
        {
            Debug.Log("Player has full health");
        }
        else
        {
            Debug.Log("Player does not have full health");
        }
    }

    void Horror()
    {
        for (int i = 0; i < cars.Length; i++)
        {
            Debug.Log(cars[i]);
        }
    }
}
