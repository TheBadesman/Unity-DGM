using UnityEngine;
using UnityEngine.Events;

public class monoEventBehavior : MonoBehaviour
{

    public UnityEvent startEvent, awakeEvent, disableEvent, invisibleEvent, visibleEvent;

    private void Awake() 
    {
        
        awakeEvent.Invoke();
        
    }
    
    private void Start() 
    {

        startEvent.Invoke();

    }

    private void OnDisable() 
    {

        disableEvent.Invoke();
        
    }

    private void OnBecameInvisible() 
    {

        invisibleEvent.Invoke();

    }

    private void OnBecameVisible() 
    {

        visibleEvent.Invoke(); 
           
    }

}
