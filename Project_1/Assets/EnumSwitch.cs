using System;
using UnityEngine.Events;
using UnityEngine;

public class EnumSwitch : MonoBehaviour
{
    public enum States
    {
        Start,
        Playing,
        End
    }

    public States currentState;

    public UnityEvent onStartEvent, onPlayingEvent, onEndEvent;

    void Update()
    {
        switch (currentState)
        {
            case States.Start:
                onStartEvent.Invoke();
                break;
            case States.Playing:
                onPlayingEvent.Invoke();
                break;
            case States.End:
                onEndEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
