using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTiRaggiunge : MonoBehaviour
{
    public  float distance;
    private float tuaMamma = 0.6f;
    public GameObject cameraPlayer, cameraJumpScare;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = apriPorte.distanceFromTarget;

        if (distance <= tuaMamma) {
            cameraPlayer.SetActive(false);
            cameraJumpScare.SetActive(true);
        }

    }
}
