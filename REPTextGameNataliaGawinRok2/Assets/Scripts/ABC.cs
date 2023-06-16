using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABC : MonoBehaviour
{

    int min = 1;
    int max = 1001;
    int shoot = 500;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Witam w grze - pomysl w glowie liczbe od 1 do 1000");
        Debug.Log("Czy twoja liczba jest równa/wieksza/mniejsza od 500?");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = shoot;
            NextShoot();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = shoot;
            NextShoot();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Komputer zgad³ liczbe");
        }

    }

    void NextShoot()
    {
        shoot = (min + max) / 2;
        Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od " + shoot + " ?");
    }
}
