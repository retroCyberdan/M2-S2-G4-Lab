using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] arrayFinale = GeneraArray(20);
        SommaArray(arrayFinale);
        StampaArray(arrayFinale);
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
            array[i] = Random.Range(1, 101);
        }
        return array;
    }

    //Creo la funzione 'SommaArray()' che ha come grandezza il valore assegnato a 'dimensione'
    int SommaArray(int[] array)
    {
        int somma = 0;
        for (int i = 0; i < array.Length; i++)//come condizione uso la funzione '.Length' per assegnare in auto il valore della grandezza dell'Array
        {
            somma += array[i];//sommo tutti i valori contenuti in ogni indice (equivale a somma = somma + array[i])
        }
        return somma;
    }

    void StampaArray(int[] array)
    {
        Debug.Log("Ecco tutti gli elementi del tuo Array composto da " + array.Length + " elementi:");
        for (int i = 0; i < array.Length; i++)//come condizione uso la funzione '.Length' per assegnare in auto il valore della grandezza dell'Array
        {
            Debug.Log(array[i]);
        }
    }

}
