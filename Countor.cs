using System;
using System.Collections;
using UnityEngine;

public class Countor : MonoBehaviour
{
    private Coroutine _coroutine;

    private int score = 0;

    public event Action<int> ProcessedEvent;

    private float interval = 0.5f;

    private void Update()
    {
        GetHandler();
    }

    private void GetHandler()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_coroutine == null)
            {
                _coroutine = StartCoroutine(TimeCounter());
            }
            else
            {
                StopCoroutine(_coroutine);
                _coroutine = null;
            }
        }
    }

    private IEnumerator TimeCounter()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(interval);
            score++;
            ProcessedEvent?.Invoke(score);
        }
    }
}
