using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoveNumberTwo : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        transform.position += new Vector3(0, 0, _moveSpeed * Time.deltaTime);
        transform.localScale *= _scaleSpeed;
        transform.RotateAround(transform.position, transform.up, _rotationSpeed * Time.deltaTime);
    }
}
