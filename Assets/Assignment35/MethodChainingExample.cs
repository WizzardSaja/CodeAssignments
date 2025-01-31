using UnityEngine;

namespace Assignment35
{
    public class MethodChainingExample : MonoBehaviour
    {
        public MethodChainingExample SetPosition(Vector3 position)
        {
            transform.position = position;
            return this;
        }

        public MethodChainingExample SetRotation(Vector3 rotation)
        {
            transform.rotation = Quaternion.Euler(rotation);
            return this;
        }

        public MethodChainingExample SetScale(Vector3 scale)
        {
            transform.localScale = scale;
            return this;
        }

        void Start()
        {
            SetPosition(new Vector3(0, 1, 0))
            .SetRotation(new Vector3(45, 0, 0))
            .SetScale(new Vector3(2, 2, 2));
        }
    }
}
