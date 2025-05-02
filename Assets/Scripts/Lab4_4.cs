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
        ////Ho ipotizzato 2 risoluzioni per questo esercizio. La prima più rapida
        ////tramite un banale ciclo FOR, la seconda altrettanto semplice ma usando
        ////un Array, per fare pratica.
        ////
        ////
        ////
        //Debug.Log("Partendo da " + start + ", i " + amount + " valori successivi sono:");
        //for (int i = start; i <= start + amount; i++)
        //{
        //    Debug.Log(i);
        //}

        //Creo un array che ha una grandezza pari al valore di 'amount' + 1, altrimenti stamperebbe
        //solo i 3 valori successivi, calcolando anche il valore di partenza
        int[] array = new int[amount + 1];

        //uso un ciclo for per popolare l'array
        for (int i = 0; i < array.Length; i++)//come condizione uso la funzione '.length' per assegnare in auto il valore della grandezza dell'array
        {
            array[i] = start + i;//ad ogni ciclo assegnerà all'indice 'i' dell'array il valore di 'start+i'
        }

        Debug.Log("Partendo da " + start + ", i " + amount + " valori successivi sono:");//uso un ciclo for per stampare in console il valore dell'array
        for (int i = 0; i < array.Length; i++)//come condizione uso la funzione '.length' per assegnare in auto il valore della grandezza dell'array
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
