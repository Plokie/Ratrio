using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSprite : MonoBehaviour
{
    [SerializeField] Transform target;
    
    void Update()
    {
        if(Camera.main.orthographic)
        {
            transform.rotation = target.rotation;
        }
        else
        {
            transform.LookAt(Camera.main.transform.position, Vector3.up);
        }
    }
}