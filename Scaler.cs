using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    Vector3 newScale = Vector3.one;

    void Update()
    {
        transform.localScale += newScale * _scaleSpeed * Time.deltaTime;
    }
}
