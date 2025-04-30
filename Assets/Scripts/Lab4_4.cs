using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_4 : MonoBehaviour
{
    //Creao due variabili pubbliche modificabili nell'Inspector
    public int start = 5;
    public int amount = 4;

    // Start is called before the first frame update
    void Start()
    {
        //Creo un Array che ha una grandezza pari al valore di 'amount' + 1
        int[] array = new int[amount + 1];

        //Uso un ciclo FOR per popolare l'Array
        for (int i = 0; i < array.Length; i++)//come condizione uso la funzione '.Length' per assegnare in auto il valore della grandezza dell'Array
        {
            array[i] = start + i;//ad ogni ciclo assegnerà all'indice 'i' dell'array il valore di 'start+i'
        }

        Debug.Log("Partendo da " + start + ", i " + amount + " valori successivi sono:");//Uso un ciclo FOR per stampare in Console il valore dell'Array
        for (int i = 0; i < array.Length; i++)//come condizione uso la funzione '.Length' per assegnare in auto il valore della grandezza dell'Array
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
