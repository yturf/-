using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _moveSpeed;

    Vector3 newScale = new Vector3(0.1f, 0.1f, 0.1f);

    private void Update()
    {
        transform.position += new Vector3(0, 0, _moveSpeed * Time.deltaTime);
        transform.localScale += newScale * _scaleSpeed * Time.deltaTime;
        transform.RotateAround(transform.position, transform.up, _rotationSpeed * Time.deltaTime);
    }
}
