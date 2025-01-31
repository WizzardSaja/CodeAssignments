using UnityEngine;
using System.Collections.Generic;

namespace Assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {
        void Start()
        {
            // Sorting in Descending Order
            List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };
            numbers.Sort((x, y) => y.CompareTo(x));
            Debug.Log("Sorted List: " + string.Join(", ", numbers));

            // Filtering Even Numbers
            List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
            List<int> filteredNumbers = numbers2.FindAll(x => x % 2 == 0);
            Debug.Log("Filtered Evens: " + string.Join(", ", filteredNumbers));
        }
    }
}
