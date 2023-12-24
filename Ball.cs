using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private GameObject pedal;
    private bool gameStart = false;

    void Start()
    {
        pedal = GameObject.FindObjectOfType<Pedal>().gameObject;
    }

    void Update()
    {
        if(!gameStart)
        {
            transform.position = new Vector3(pedal.transform.position.x, transform.position.y, transform.position.z);
        }
        if (Input.GetMouseButtonDown(0) & !gameStart)
        {
            gameStart=true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }
    }
}
