using unityengine;
using System.Collections;
using System.Collections.Generic;   


abstract class Freccia : Proiettile
{
    virtual public void Lancia()
    {
        // Implementazione del lancio della freccia
        Debug.Log("Lancio della freccia a una velocità di " + velocita + "!");
    }

    public Freccia(float velocita) : base(velocita)
    {
        this.velocita = velocita + 5;
        //implementiamo un incremento di velocità per la freccia
    }
}