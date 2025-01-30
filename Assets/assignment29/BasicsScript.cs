using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var number = 5;
            var text = "Hello, Unity!";
            var isEven = (number % 2 == 0) ? true : false;

            // String Interpolation
            Debug.Log($"The number {number} is {(isEven ? "even" : "odd")}.");

            //******************

            Debug.Log($"Current Date: {DateTime.Now.ToShortDateString()}");
            Debug.Log($"Current Time: {DateTime.Now.ToLongTimeString()}");
            Debug.Log($"Current Day: {DateTime.Now.DayOfWeek}");
        }
    }
}