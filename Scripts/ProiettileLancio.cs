using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProiettileLancio : MonoBehaviour {
    
List <Proiettile> ListaProiettili = new List<Proiettile>();

ListaProiettili.Add(new Freccia(10));
ListaProiettili.Add(new PallaMagica(20));
ListaProiettili.Add(new Shuriken(30, 5));

for (int = i ; i < ListaProiettili.Count; i++)
{
    ListaProiettili[i].Lancia();
    // Implementazione del lancio del proiettile
}




}