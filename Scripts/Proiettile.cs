using UnityEngine;
using System.Collections.Generic;
using System.Collections;

abstract class Proiettile {



    protected float velocita;

    abstract public void Lancia();
    


    public Proiettile(float velocita)
    {
        this.velocita = velocita;
    }

}
