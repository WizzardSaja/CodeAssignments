using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections.Generic;
using UnityEngine;
namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {
        void Start()
        {
            Creature kangaroo = new Kangaroo();
            Creature duck = new Duck();

            List<Creature> creatures = new List<Creature> { kangaroo, duck };
            List<IRunnable> runnableCreatures = new List<IRunnable>();
            List<IJumpable> jumpableCreatures = new List<IJumpable>();
            List<ISwimmable> swimmableCreatures = new List<ISwimmable>();

            runnableCreatures.Add(kangaroo as IRunnable);
            jumpableCreatures.Add(kangaroo as IJumpable);
            runnableCreatures.Add(duck as IRunnable);
            swimmableCreatures.Add(duck as ISwimmable);

            foreach (var creature in creatures)
            {
                creature.Speak();
            }

            foreach (var runnable in runnableCreatures)
            {
                runnable?.Run();
            }

            foreach (var jumpable in jumpableCreatures)
            {
                jumpable?.Jump();
            }

            foreach (var swimmable in swimmableCreatures)
            {
                swimmable?.Swim();
            }
        }
    }
}