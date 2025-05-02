using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_2 : MonoBehaviour
{
    //Dichiaro 4 variabili pubbliche editabili nell'Inspector, assegnandogli dei valori
    public int a = 1;
    public int b = 2;
    public int c = 3;
    public int d = 4;

    // Start is called before the first frame update
    void Start()
    {
        //Creo un Array di 4 numeri interi
        int[] array = new int[4];
        //Assegno i valori delle variabili pubbliche ai vari indici dell'array
        array[0] = a;
        array[1] = b;
        array[2] = c;
        array[3] = d;

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
            Debug.Log("La Somma dei " + array.Length + " numeri è " + somma);
            Debug.Log("Il Prodotto dei " + array.Length + " numeri è " + prodotto);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
