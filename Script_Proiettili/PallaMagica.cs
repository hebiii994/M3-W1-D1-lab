using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PallaMagica : Proiettile
{

    public override void Lancia()
    {
        Debug.Log("la palla magica � stata lanciata alla velocit� di " + velocita);
    }


    public PallaMagica(float velocita) :base(velocita)
    {

    }



}