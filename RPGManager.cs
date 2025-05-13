using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Character> characters = new List<Character>();
        characters.Add(new Warrior("Ezio", 50));
        characters.Add(new Archer("LegoLand", 30));
        characters.Add(new Mage("Tonino", 40));

        foreach (Character character in characters)
        {
            int dannoSubito = Random.Range(0, 21);

            Debug.Log(character.Name + " attacca. I suoi HP attuali sono " + character.Health);
            character.Attack();

            character.TakeDamage(dannoSubito);
            Debug.Log(character.Name + " viene attaccato e subisce " + dannoSubito + " I suoi HP attuali sono " + character.Health);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
