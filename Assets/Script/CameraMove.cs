using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform camPlay;

    // Start is called before the first frame update
    void Start()
    {
        camPlay = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 temp = transform.position;

        temp.x = camPlay.position.x;

        transform.position = temp;
    }
}
