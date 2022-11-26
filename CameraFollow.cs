using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public Space offsetspace = Space.Self;
    private bool lookAt = true;
   
    
    private void LateUpdate()
    {
        if(target==null)
        {
            return;
        }
        if(offsetspace == Space.Self)
        {
            transform.position = target.TransformPoint(offset);
        }
        else
        {
            transform.position = target.position + offset;
        }

        if (lookAt)
        {
            transform.LookAt(target);
        }
        else
        {
            transform.position = target.position;
        }
    }
}
