using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Creo un Array di 4 numeri interi
        int[] array = new int[4];
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;

        for (int i = 0; i < 2; i++)
        {
            //Calcolo la Somma dei valori dell'Array
            int somma = 0;
            for (int a = 0; a < array.Length; a++)
            {
                somma += array[a];
            }

            //Calcolo il Prodotto dei valori dell'Array
            int prodotto = 1;
            for (int a = 0; a < array.Length; a++)
            {
                prodotto *= array[a];
            }

            //Stampo i risultati di Somma e Prodotto
            Debug.Log("La Somma è " + somma);
            Debug.Log("Il Prodotto è " + prodotto);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
