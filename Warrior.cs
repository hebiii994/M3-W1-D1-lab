using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Character
{
    public int dmg = 10;
    
    public override void Attack()
    {
        
        Debug.Log($"{Name} ha inflitto {dmg}");
    }

    public override void TakeDamage(int damage)
    {
       this.Health -= damage;
       Debug.Log($"{Name} prende {damage} danni e resta con {Health}");
    }
    public Warrior (string Name, int Health) : base (Name, Health)
    {

    }










}
