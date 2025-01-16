using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment27
{
    public class callingbyRbyV : MonoBehaviour
    {
        void Start()
        {
            // Declare and initialize variables
            int a = 5;
            int b = 10;

            Debug.Log($"Initial value of a: {a}");
            Debug.Log($"Initial value of b: {b}");

            // Call by Value
            CallByValue(a);
            Debug.Log($"Value of a after CallByValue: {a}");

            // Call by Reference
            CallByReference(ref b);
            Debug.Log($"Value of b after CallByReference: {b}");

            // Using out Keyword
            int c; // Variable not initialized
            UseOutKeyword(out c);
            Debug.Log($"Value of c after UseOutKeyword: {c}");
        }

        // Call by Value method
        void CallByValue(int value)
        {
            value += 10;
            Debug.Log($"Inside CallByValue, modified value: {value}");
        }

        // Call by Reference method
        void CallByReference(ref int value)
        {
            value += 10;
            Debug.Log($"Inside CallByReference, modified value: {value}");
        }

        // Using out Keyword method
        void UseOutKeyword(out int value)
        {
            value = 20; // Assigning a new value
            Debug.Log($"Inside UseOutKeyword, assigned value: {value}");
        }
    }
}
