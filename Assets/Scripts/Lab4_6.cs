using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Creo la funzione 'GeneraArray()' che ha come grandezza il valore assegnato a 'dimensione'
    int[] GeneraArray(int dimensione)
    {
        int[] array = new int[dimensione];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = UnityEngine.Random.Range(0, 101);
        }
        return array;
    }

    int SommaArray(int[] array)
    {
        int[] mioArray = GeneraArray(array.Length);
        int somma = 0;
        for (int i = 0; i < mioArray.Length; i++)
        {
            somma += array[i];
        }
        return somma;
    }

    //void StampaArray()
    //{
    //    for (int i = 0; i < array.Length; i++)//come condizione uso la funzione '.Length' per assegnare in auto il valore della grandezza dell'Array
    //    {
    //        Debug.Log(array[i]);
    //    }
    //}

}
