using UnityEngine;
using System.Collections;

public class Lightswitch : MonoBehaviour {

    public Light myLight;
    bool lightLatch;


    void Setup()
    {

        lightLatch = false;
        myLight.enabled = false;

    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("tab"))
        {
            lightLatch = !lightLatch;
        }
        if (lightLatch == true)
        {
            myLight.enabled = true;
            //myLight.intensity = 1.0f;
        }
        else
        {
            myLight.enabled = false;
            //myLight.intensity = 0.0f;
        }
    }
}
