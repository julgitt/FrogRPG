using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float _smoothValue;

    [Header("Camera Settings")]
    [SerializeField] private Transform _target;

    private void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, _target.position, Time.deltaTime * _smoothValue);
        newPos.z = -10f;
        transform.position = newPos;
    }
}
