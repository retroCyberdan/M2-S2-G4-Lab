using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num = 0; 
        int index = 10;
        while (index > 0)
        {
            Debug.Log("Il valore di 'numero' è " + num);
            num++;
            index--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
