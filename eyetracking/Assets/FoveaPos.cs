using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;


public class FoveaPos : MonoBehaviour
{
   
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 gazePoint = TobiiAPI.GetGazePoint().Screen;

        Vector3 foveaPos = cam.ScreenToWorldPoint(new Vector3(gazePoint.x, gazePoint.y, cam.nearClipPlane));

        gameObject.GetComponent<RectTransform>().position = foveaPos;
    }
}
