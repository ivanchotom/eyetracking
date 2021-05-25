using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCamScript : MonoBehaviour
 {

    public Camera FirstPersonCam, ThirdPersonCam;
    public KeyCode TKey;
    public bool camSwitch;

    public float friend { get;private set; } 

     void Update()
    {
        if (Input.GetKeyDown(TKey))
        {
            camSwitch = !camSwitch;
            FirstPersonCam.enabled = camSwitch;
            ThirdPersonCam.enabled = !camSwitch;
        }
       //float freind1 = gameObject.GetComponent<MapCamScript>().friend;
    }

    
  

}
    

    