using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PallaMagica : Proiettile 
{
    
virtual public void Lancia()
{
    Debug.Log("Lancio della palla magica ad una velocità di " + velocita + "!");
    // Implementazione del lancio della palla magica
}

public PallaMagica(float velocita) : base(velocita)
{
    this.velocita = velocita - 5;
    // Implementiamo un decremento di velocità per la palla magica, è un attacco lento


}