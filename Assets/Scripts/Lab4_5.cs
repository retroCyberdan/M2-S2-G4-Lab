using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_5 : MonoBehaviour
{
    //Dichiaro la variabile pubblica intera 'find'
    public int find;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Proverò a trovare il numero 'Found' (" + find + "):");//lìLimitatamente a questo caso, creo un Arry di grandezza 'find'
        int[] array = new int[find];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(0, find + 1);//essendo 'find' di type int, incremento di 1 per considerarlo nel conteggio
            if (array[i] == find)
            {
                Debug.Log(array[i] + " --> Found!");
            }
            else
            {
                Debug.Log(array[i] + " --> Not Found...");
            }
        }
        Debug.Log("Iterations Finished");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
