using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector3 offset = new Vector3(0, 5, -5);
    public Transform target;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position + offset;
        Vector3 lookAtTarget = target.position + new Vector3(0, 0, 0.5f);
        transform.LookAt(lookAtTarget);
    }
}
