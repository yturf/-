using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    Vector3 newScale = new Vector3(0.1f, 0.1f, 0.1f);
  
    private void Update()
    {
        transform.localScale += newScale * _scaleSpeed * Time.deltaTime;
    }
}
