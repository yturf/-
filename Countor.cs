using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Countor : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    int score = 0;
    float interval = 0.5f;

    private void Start()
    {
        _text.text = "";
    }

    private void Update()
    {
        OnClick();
    }
    public void OnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(timeCounter());
        }

        else if (Input.GetMouseButtonDown(1))
        {
            StopAllCoroutines();
        }
    }

    private IEnumerator timeCounter()
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);
            score++;
            _text.text = "" + score;
        }
    }
}
