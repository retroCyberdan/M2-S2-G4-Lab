using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_1 : MonoBehaviour
{
    //Dichiaro le variabili pubbliche 'num' e 'index'
    public int num = 0;
    public int index = 10;//assegno ad 'index' un valore indicativo di 10, editabile nell'Inspector

    // Start is called before the first frame update
    void Start()
    {
        
        while (index > 0)
        {
            Debug.Log("Il valore di 'num' è " + num);//stampera ad ogni ciclo il valore di 'num'
            num++;//incrementa di 1 il valore di 'num'
            index--;//decrementa di 1 il valore di 'index' finchè la condizione del ciclo non sarà più TRUE
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
