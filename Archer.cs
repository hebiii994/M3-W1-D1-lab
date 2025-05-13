using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Character
{
    int baseDmg = 7;
    
    public override void Attack()
    {
        int comboNum = 2;
        for (int i = 0; i < comboNum; i++)
        {
            Debug.Log($"{Name} ha inflitto {baseDmg} con la freccia numero {i+1}");
        }
       

    }
    public override void TakeDamage(int damage)
    {
        this.Health -= damage;
        Debug.Log($"{Name} prende {damage} danni e resta con {Health}");
    }

    public Archer(string name, int damage) : base(name, damage) 
    { 

    }

    

}
