using UnityEngine;

namespace Assignment35
{
    // Abstract Base Class
    public abstract class AbstractBaseClass
    {
        public abstract void PerformAction();
        public void PrintInfo()
        {
            Debug.Log("This is a concrete method in the abstract base class.");
        }
    }

    // Derived Class
    public class DerivedClassExample : AbstractBaseClass
    {
        public override void PerformAction()
        {
            Debug.Log("PerformAction is implemented in the derived class.");
        }
    }

    // MonoBehaviour Class for Testing
    public class TestAbstractClass : MonoBehaviour
    {
        void Start()
        {
            DerivedClassExample example = new DerivedClassExample();
            example.PerformAction();
            example.PrintInfo();
        }
    }
}
