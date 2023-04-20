using UnityEngine;
using UnityEngine.Events;

public class TimedEvent : MonoBehaviour
{
    public UnityEvent onDelayElapsed;

    private void Start()
    {
        Invoke("InvokeEvent", 0.01f);
    }

    private void InvokeEvent()
    {
        onDelayElapsed.Invoke();
    }
}