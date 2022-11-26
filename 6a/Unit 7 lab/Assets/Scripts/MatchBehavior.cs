using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : IDContainerBehaviour
{

    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent, startEvent, noMatchDelayedEvent;
    private ID otherID;

    public void Start()
    {

        startEvent.Invoke();

    }

    private IEnumerator OnTriggerEnter(Collider other)
    {

        var tempObj = other.GetComponent<IDContainerBehaviour>();
        if (tempObj == null)
            yield break;
    
        var otherID = tempObj.idObj;

        if(otherID == idObj)
        {
            
           matchEvent.Invoke();

        } 
        else
        {
            
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();

        }

    }

}
