using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followTarget : MonoBehaviour
{ 
    //what i am following
    public Transform target;

    //zeros out of velocity
    Vector3 velocity = Vector3.zero;

    //time to follow target
    public float smoothTime = .15f;

    void FixedUpdate()
    {
        //target position
        Vector3 targetPos = target.position;

        //align the camera and target z position
        targetPos.z = transform.position.z;

        //usign smooth damp we will gradually change the carema transform position to the target position based on the cameras transform velocity and the smooth time
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
    }
}
