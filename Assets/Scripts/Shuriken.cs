using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shuriken : Proiettile 
{
    protected int numeroLame;
    
virtual public void Lancia()
{
    Debug.Log("Lancio dello shuriken a una velocità di " + velocita + "!");
    // Implementazione del lancio dello shuriken
    
}

public Shuriken(float velocita, int numeroLame) : base(velocita)
{
    
    this.numeroLame -= 1;
    // togliamo uno shurkien



}