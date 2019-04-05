using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{ //volgt de player
    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    
    void LateUpdate()
    {   
        // je slaat je camera positie op in variable temp
        Vector3 temp = transform.position;

        //je zetten de camera positie x gelijk aan de players x
        temp.x = playerTransform.position.x;

        //je zet de camera terug op de newe positie
        transform.position = temp;
    }
}
