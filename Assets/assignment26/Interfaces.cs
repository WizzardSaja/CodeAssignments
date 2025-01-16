using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment26
{
    public interface IRunnable
    {
        void Run();
    }

    public interface IJumpable
    {
        void Jump();
    }

    public interface ISwimmable
    {
        void Swim();
    }
}