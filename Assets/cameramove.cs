using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    private Vector3 CameraPosition;

    [Header("Camera Settings")]
    public float CameraSpeed;
    // Start is called before the first frame update
    void Start()
    {
        CameraPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            CameraPosition.x += CameraSpeed/10;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            CameraPosition.x -= CameraSpeed / 10;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            CameraPosition.z += CameraSpeed / 10;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            CameraPosition.z -= CameraSpeed / 10;
        }
        if (Input.GetKey(KeyCode.KeypadMinus))
        {
            CameraPosition.y -= CameraSpeed / 10;
        }
        if (Input.GetKey(KeyCode.KeypadPlus))
        {
            CameraPosition.y += CameraSpeed / 10;
        }
        if (Input.GetKey(KeyCode.R))
        {
            transform.RotateAround(transform.position, Vector3.up, 360 * Time.deltaTime);
        }
        this.transform.position = CameraPosition;
    }
}
