using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Eseguo la stampa in Console della tabellina del 3 usando 1 ciclo FOR
        Debug.Log("Ecco la tabellina del 3!");
        for (int i = 0; i < 10; i++)
        {
            int n = (i + 1) * 3;
            Debug.Log("3 x " + (i + 1) + " = " + n);
        }

        ////Eseguo la stampa in Console della tabellina del 3 usando 1 ciclo WHILE
        //Debug.Log("Ecco la tabellina del 3!");
        //int i = 0;
        //while (i < 10)
        //{
        //    int n = (i + 1) * 3;
        //    Debug.Log("3 x " + (i + 1) + " = " + n);
        //    i++;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
