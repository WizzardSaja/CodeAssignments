using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class TestCustomObject : MonoBehaviour
    {
        void Start()
        {
            CustomObject obj1 = new CustomObject(1, "Example");
            print(obj1.ToString());  

            //اختبار المقارنة
            CustomObject obj2 = new CustomObject(1, "Example");
            print(obj1 == obj2 ? "Objects are equal" : "Objects are not equal");
        }
    }
}

