using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanciaProiettile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Proiettile> listaProiettili = new List<Proiettile>();

        listaProiettili.Add(new Freccia(10));
        listaProiettili.Add(new PallaMagica(5));

        //for (int i = 0; i < listaProiettili.Count; i++)
        //{
        //    listaProiettili[i].Lancia();
        //}

       foreach (Proiettile item in listaProiettili) 
        {
            item.Lancia();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
