using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private Coroutine _coroutine;
    private int _score = 0;
    private float _interval = 0.5f;

    public event Action<int> Account;

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
            yield return new WaitForSeconds(_interval);
            _score++;
            Account?.Invoke(_score);
        }
    }
}
