using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Vector3 _movementDirection;

    Vector3 newScale = Vector3.one;

    private void Update()
    {
        transform.Translate(_movementDirection * Time.deltaTime, Space.Self);
        transform.localScale += newScale * _scaleSpeed * Time.deltaTime;
        transform.RotateAround(transform.position, transform.up, _rotationSpeed * Time.deltaTime);
    }
}
