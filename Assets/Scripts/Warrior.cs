using unityengine;
using System.Collections;
using System.Collections.Generic;


abstract class Warrior : Character

{

public Warrior(string name, int health, int attackPower, int defensePower, bool berserkMode) : base(name, health, attackPower, defensePower)
{
    // Implementazione del costruttore della classe Warrior
    this.berserkMode = berserkMode;

virtual public void Attack(Warrior target)
{
    if (this.berserkMode)
    {
        target.TakeDamage(this.attackPower * 2); // Doppio danno in modalità berserker
    }
    else
    {
        target.TakeDamage(this.attackPower);
    }



}
}