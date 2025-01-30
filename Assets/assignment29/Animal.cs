using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

namespace Assignment29
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal sound");
        }

        public void Move()
        {
            Debug.Log("Animal moves.");
        }
    }
}
