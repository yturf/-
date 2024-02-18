using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, transform.up, _rotationSpeed * Time.deltaTime);
    }
}
