using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour
{
    private Vector3 scaleUp;
    private Vector3 scaleDown;
    private Vector3 x,up,down;
    private Vector3 check;
    // Start is called before the first frame update
    void Start()
    {
        scaleUp = new Vector3(0.5f,0.5f,0.5f);
        scaleDown = new Vector3(-0.5f, -0.5f, -0.5f);
        x = transform.localScale;
        up = x + scaleUp;
        down = x + scaleDown;
        check = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 34f && transform.position.z < -32f)
        {
            transform.Translate((float)0.0, (float)-0.01, (float)0.0);
            transform.localScale = up;
        }
        else if (transform.position.x < -21f && transform.position.z < -32f)
        {
            transform.Translate((float)0.0, (float)0.01, (float)0.0);
            transform.localScale = x;
        }
        else if (transform.position.x > 33f && transform.position.z > 24f)
        {
            transform.Translate((float)0.0, (float)0.01, (float)0.0);
            transform.localScale = x;
        }
        else if (transform.position.x < -24f && transform.position.z > 24f)
        {
            transform.Translate((float)0.0, (float)0.01, (float)0.0);
            transform.localScale = down;
        }
    }
}
