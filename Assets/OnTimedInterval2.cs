using System.Collections;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Call different events with multiple time intervals repeatedly during the lifetime of object.
/// </summary>
public class OnTimedInterval2 : MonoBehaviour
{
    [SerializeField] private bool _debugComments;

    [System.Serializable]
    public class TimedEvent
    {
        [Tooltip("The time interval for this event")]
        public float interval = 1.0f;
        [Tooltip("The event to call when the interval elapses")]
        public UnityEvent onIntervalElapsed;
    }

    [Tooltip("The list of timed events")]
    public TimedEvent[] timedEvents;

    private void Start()
    {
        StartCoroutine(IntervalRoutine());
    }

    private IEnumerator IntervalRoutine()
    {
        while (true)
        {
            foreach (TimedEvent timedEvent in timedEvents)
            {
                float interval = timedEvent.interval;
                if (_debugComments) Debug.Log($"waiting for {interval} seconds");
                yield return new WaitForSeconds(interval);
                if (_debugComments) Debug.Log($"interval {interval} elapsed");
                PlayEvent(timedEvent.onIntervalElapsed);
            }
        }
    }

    private void PlayEvent(UnityEvent unityEvent)
    {
        unityEvent.Invoke();
    }
}

