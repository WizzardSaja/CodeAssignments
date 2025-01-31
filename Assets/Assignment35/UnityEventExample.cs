using UnityEngine;
using UnityEngine.Events;

namespace Assignment35
{
    public class UnityEventExample : MonoBehaviour
    {
        public UnityEvent onEventTriggered;

        void Start()
        {
            if (onEventTriggered == null)
                onEventTriggered = new UnityEvent();

            onEventTriggered.AddListener(OnEventResponse);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                onEventTriggered.Invoke();
            }
        }

        void OnEventResponse()
        {
            Debug.Log("The event has been triggered!");
        }
    }
}

