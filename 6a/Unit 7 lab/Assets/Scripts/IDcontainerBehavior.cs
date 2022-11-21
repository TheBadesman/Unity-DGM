using UnityEngine;
using UnityEngine.Events;

public class IDcontainerBehavior : MonoBehaviour
{

    public ID idObj;
    public UnityEvent startEvent;

    public void Start()
    {

        startEvent.Invoke();

    }

}
