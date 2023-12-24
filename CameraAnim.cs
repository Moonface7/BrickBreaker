using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnim : MonoBehaviour
{
    private Vector3 firstPos;
    void Start()
    {
        firstPos = transform.position;
        transform.position = new Vector3(firstPos.x,firstPos.y -6f,firstPos.z);
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, firstPos, 2*Time.deltaTime);
    }
}
