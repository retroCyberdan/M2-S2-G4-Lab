using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //A differenza del primo esercizio extra, dove si richedeva la stampa di un'unica tabellina,
        //qui abbiamo la necessità di sfruttare un'ulteriore variabile (definita come "tabellina")
        //come contatore della tabellina da calcolare:
        //
        //
        //
        //Eseguo la stampa in Console delle tabelline dall'1 al 10 usando 2 cicli FOR
        //for (int tabellina = 1; tabellina <= 10; tabellina++)
        //{
        //    Debug.Log("Ecco la tabellina del " + tabellina + "!");
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        int multi = i * tabellina;
        //        Debug.Log(tabellina + " x " + i + " = " + multi);
        //    }
        //}

        //Eseguo la stampa in Console delle tabelline dall'1 al 10 usando 2 cicli WHILE
        int tabellina = 1;
        while (tabellina <= 10)
        {
            Debug.Log("Ecco la tabellina del " + tabellina + "!");
            int i = 1;
            while (i <= 10)
            {
                int multi = i * tabellina;
                Debug.Log(tabellina + " x " + i + " = " + multi);
                i++;
            }
            tabellina++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
