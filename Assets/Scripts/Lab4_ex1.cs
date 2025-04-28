using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Lab4_ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Eseguo la stampa in Console della tabellina del 3 usando 1 ciclo FOR
        //Debug.Log("Ecco la tabellina del 3!");
        //for (int i = 1; i<=10; i++)
        //{
        //    int multi = i * 3;
        //    Debug.Log("3 x " + i + " = " + multi);
        //}

        //Eseguo la stampa in Console della tabellina del 3 usando 1 ciclo WHILE
        UnityEngine.Debug.Log("Ecco la tabellina del 3!");
        int i = 1;
        while (i <= 10)
        {
            int multi = i * 3;
            Debug.Log("3 x " + i + " = " + multi);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
