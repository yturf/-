using System;
using System.Collections;
using UnityEngine;

public class Countor : MonoBehaviour
{
    private Coroutine _coroutine;

    public int score = 0;

    public event Action<int> CoroutineEvent;

    float interval = 0.5f;

    private void Update()
    {
        EventHandler();
    }
    public void EventHandler()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _coroutine = StartCoroutine(TimeCounter());
        }

        else if (Input.GetMouseButtonDown(1))
        {
            StopCoroutine(_coroutine);
        }
    }

    private IEnumerator TimeCounter()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(interval);
            score++;
            CoroutineEvent?.Invoke(score);
        }
    }
}
