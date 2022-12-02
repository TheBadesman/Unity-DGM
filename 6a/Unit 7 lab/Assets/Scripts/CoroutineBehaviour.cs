using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUnitlFalseEvent;

    public bool canRun;

    public IntData counterNum;

    public float seconds = 3.0f;

    private WaitForSeconds wfsObj;

    private WaitForFixedUpdate wffuObj;

    public void Start()
    {

        startEvent.Invoke();

    }

    public void StartCounting()
    {

        StartCoroutine(Counting());

    }

    private IEnumerator Counting()
    {

        wfsObj = new WaitForSeconds(seconds);

        wffuObj = new WaitForFixedUpdate();

        startCountEvent.Invoke();

        while (counterNum.value > -1)
        {

            yield return wfsObj;
            repeatCountEvent.Invoke();
            counterNum.value--;

        }

        endCountEvent.Invoke();

    }

    public void StartReapeatUntilFalse()
    {

        canRun = true;
        StartCoroutine(RepeatUntilFalse());

    }

    private IEnumerator RepeatUntilFalse()
    {

        while (canRun)
        {

            yield return wfsObj;

            repeatUnitlFalseEvent.Invoke();

        }

    }
}
