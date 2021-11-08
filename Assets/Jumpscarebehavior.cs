using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscarebehavior : MonoBehaviour
{

    public GameObject MainCam;

    // Update is called once per frame
    void Update()
    {
        transform.position = MainCam.transform.position;
        transform.rotation = MainCam.transform.rotation;
    }
}
