using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float xRange = 45.0f;
    public float MxRange = -35.0f;
    public float zRange = 37.0f;
    public float MzRange = -43.0f;
    public float yRange = 10.0f;
    public float MyRange = -10.0f;

    // Update is called once per frame
    void Update()
    {
        //x a3onas
        if (Input.GetKey(KeyCode.D)) {
            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }
            else
            {
                transform.Translate((float)0.1, (float)0.0, (float)0.0);
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x < MxRange)
            {
                transform.position = new Vector3(MxRange, transform.position.y, transform.position.z);
            }
            else
            {
                transform.Translate((float)-0.1, (float)0.0, (float)0.0);
            }
        }
        //z a3onas
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.z > zRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
            }
            else {
                transform.Translate((float)0.0, (float)0.0, (float)0.1);
            }
        }
        else if (Input.GetKey(KeyCode.X))
        {
            if (transform.position.z < MzRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, MzRange);
            }
            else
            {
                transform.Translate((float)0.0, (float)0.0, (float)-0.1);
            }
        }
        //y a3onas
        if (Input.GetKey(KeyCode.E))
        {
            if (transform.position.y > yRange)
            {
                transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
            }
            else {
                transform.Translate((float)0.0, (float)0.1, (float)0.0);
                
            }
        }
        else if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y < MyRange)
            {
                transform.position = new Vector3(transform.position.x, MyRange, transform.position.z);
            }
            else
            {
                transform.Translate((float)0.0, (float)-0.1, (float)0.0);
            }
        }
    }
}
