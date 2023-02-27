using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyRotation : MonoBehaviour
{
    [SerializeField] Transform target;
    
    void Update()
    {
        transform.rotation = target.rotation;
    }
}