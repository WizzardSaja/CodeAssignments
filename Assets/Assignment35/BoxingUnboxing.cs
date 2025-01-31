namespace Assignment35{
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        void Start()
        {
            int health = 100;
            object boxedHealth = health; // Boxing
            int unboxedHealth = (int)boxedHealth; // Unboxing
            unboxedHealth += 50;

            Debug.Log($"Original Value: {health}");
            Debug.Log($"Boxed Value: {boxedHealth}");
            Debug.Log($"Unboxed and Modified Value: {unboxedHealth}");
        }
    }
}
}