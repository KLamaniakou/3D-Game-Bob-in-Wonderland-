using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 27f && transform.position.z < -28f)
        {
            rend.sharedMaterial = material[0];
        }
        else if (transform.position.x < -28f && transform.position.z < -28f)
        {
            rend.sharedMaterial = material[1];
        }
        else if (transform.position.x > 28f && transform.position.z > 28f)
        {
            rend.sharedMaterial = material[3];
        }
        else if (transform.position.x < -28f && transform.position.z > 28f)
        {
            rend.sharedMaterial = material[2];
        }
    }
}
