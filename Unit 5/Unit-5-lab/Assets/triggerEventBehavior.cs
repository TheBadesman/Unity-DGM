using UnityEngine;
using UnityEngine.Events;

public class triggerEventBehavior : MonoBehaviour
{

    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider other) 
    {

        triggerEnterEvent.Invoke();
        
    }

}
