using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABC : MonoBehaviour
{


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
            Debug.Log("Nacisnieto gorna strzalke");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Nacisnieto dolna strzalke");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Nacisnieto Enter");
        }

    }
}
