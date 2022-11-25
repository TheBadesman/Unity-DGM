using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{

    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent, startEvent;
    private ID otherID;

    public void Start()
    {

        startEvent.Invoke();

    }

    public void OnTriggerEnter(Collider other)
    {

        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj == null)
            return;
    
        var otherID = tempObj.idObj;

        if(otherID == idObj)
        {
            
           matchEvent.Invoke();

        } 
        else
        {
            
            noMatchEvent.Invoke();

        }

    }

}
