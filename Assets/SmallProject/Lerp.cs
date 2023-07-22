using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    Vector2 startPosition; 
    public Vector2 endPosition;
    float step = 0; 

    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            startPosition = transform.position;
            endPosition = Vector3.right * -endPosition;
            step = 0; 
        }

        step += Time.deltaTime;
        transform.position = Vector3.Lerp(startPosition, endPosition, step);
    }
}
