using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCapsule : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
  
    void Update()
    {
        transform.localScale *= _scaleSpeed;
    }
}
