using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class TestUtilities : MonoBehaviour
    {
        void Start()
        {
            int sum = Utilities.Add(1, 2, 3, 4, 5);
            Debug.Log($"Sum: {sum}");

            string repeatedText = "Hello".RepeatString(3);
            Debug.Log(repeatedText);
        }
    }
}
