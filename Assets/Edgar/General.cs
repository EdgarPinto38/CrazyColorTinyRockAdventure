using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General : MonoBehaviour
{
    public static bool hayPiedra;
    public Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hayPiedra == true)
        {
            mainCam.enabled = false;
        }
        else
        {
            mainCam.enabled = true;
        }
    }
}
