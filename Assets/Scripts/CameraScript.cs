using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Vector3 Offset;

    void Start()
    {
        Offset = this.transform.position - GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    void Update()
    {
        this.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position + Offset;
    }
}
