using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{

    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent, setEvent;
    private ID otherID;

    public void Start()
    {

        setEvent.Invoke();

    }

    public void OnTriggerEnter(Collider other)
    {

        var tempObj = other.GetComponent<IDcontainerBehavior>();
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
