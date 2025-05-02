using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_3 : MonoBehaviour
{
    //Dichiaro una variabile pubblica editabile nell'Inspector, assegnandogli un valore
    public int numero = 1;

    // Start is called before the first frame update
    void Start()
    {
        //Creo un ciclo FOR che si ripete per 30 volte
        for (int i = 1; i <= 30; i++)
        {
            if (numero % 3 == 0 && numero % 5 == 0)
            {
                Debug.Log(numero + " è divisibile sia per 3 che per 5! FizzBuzz!");                
            }
            else if (numero % 5 == 0)
            {
                Debug.Log(numero + " è divisibile per 5! Buzz!");
            }
            else if (numero % 3 == 0)
            {
                Debug.Log(numero + " è divisibile per 3! Fizz!");
            }
            else
            {
                Debug.Log(i);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
