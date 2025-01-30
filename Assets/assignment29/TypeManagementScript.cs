using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class TypeManagementScript : MonoBehaviour
    {
        void Start()
        {
            // Upcasting 
            Animal myAnimal = new Cat(); 
            myAnimal.MakeSound();  //  Meow
            myAnimal.Move();       //  Animal moves

            // Downcasting 
            Cat myCat = myAnimal as Cat;
            if (myCat != null)
            {
                myCat.MakeSound();  //  Meow
                myCat.Move();       // Cat runs quickly
            }

            // is
            List<ICanFight> fighters = new List<ICanFight>
            {
                new Cat(),
                new Warrior()
            };

            foreach (var fighter in fighters)
            {
                fighter.Attack(); 

                if (fighter is Cat)
                    Debug.Log("The object is a Cat.");
                else if (fighter is Warrior)
                    Debug.Log("The object is a Warrior.");
            }
        }
    }
}
