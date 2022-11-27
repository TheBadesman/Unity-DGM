using System;
using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehaviour : MonoBehaviour
{

    public ID idObj;
    public UnityEvent StartEvent;

    public void OnEnable()
    {

        StartEvent.Invoke();

    }

}
