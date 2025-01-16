using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment26
{
    public class Creature
    {
        public virtual void Speak()
        {
            Debug.Log("A creature makes a sound.");
        }
    }
}