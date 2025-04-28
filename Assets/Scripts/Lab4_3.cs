using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_3 : MonoBehaviour
{
    public int numero = 1 ;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 30; i++)
        {
            if (numero % 3 == 0 && numero % 5 == 0)
            {
                Debug.Log(numero + " è divisibile sia per 3 che per 5! FizzBuzz!");
                numero++;
            }
            else if (numero % 5 == 0)
            {
                Debug.Log(numero + " è divisibile per 5! Buzz!");
                numero++;
            }
            else if (numero % 3 == 0)
            {
                Debug.Log(numero + " è divisibile per 3! Fizz!");
                numero++;
            }
            else
            {
                Debug.Log(i);
                numero++;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
