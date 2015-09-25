using UnityEngine;
using System.Collections;
using System;

public class ProximityDimmer : MonoBehaviour {

    public Transform playerTransform;
    public Vector3 playerPos;
    public static float x;
    public static float z;
    public static float y;
    Lightswitch Dimmer;

    // Use this for initialization

    void Start()
    {
        playerTransform = GameObject.Find("OVRPlayerController").transform;
        GameObject pointLight = GameObject.Find("Point light");
        Dimmer = pointLight.GetComponent<Lightswitch>();
        Dimmer.myLight.intensity = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {


        playerPos = playerTransform.position;
        x = playerPos.x;
        z = playerPos.z;
        y = playerPos.y;
        //Lightswitch.myLight.intensity = x * x;
        Dimmer.myLight.intensity = 1.0f - (float) Math.Sqrt((double)(x * x + z * z))/7.0f;
        //Dimmer.myLight.intensity = (float)(x * x);

    }
}
