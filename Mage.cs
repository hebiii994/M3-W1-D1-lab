using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Character
{
    public int dmg = 10;
    public Mage(string name, int health) : base(name, health)
    {
    }

    public override void Attack()
    {
        Debug.Log($"{Name} ha inflitto {dmg} con la palla magica");
    }

    public override void TakeDamage(int damage)
    {
        this.Health -= damage;
        Debug.Log($"{Name} prende {damage} danni e resta con {Health}");
    }









}