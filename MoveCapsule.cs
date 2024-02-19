using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
  
    private void Update()
    {
        transform.localScale *= _scaleSpeed;
    }
}
