using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    public string Name { get; set; }
    public int Health { get; set; }


    public abstract void Attack();
    public abstract void TakeDamage(int damage);


    public Character (string name, int health)
    {
        Name = name; Health = health;
    }








}