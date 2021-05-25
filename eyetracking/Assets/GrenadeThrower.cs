using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;

public class GrenadeThrower : MonoBehaviour
{
    // Start is called before the first frame update

    public float throwForce = 5f;
    public GameObject grenadePrefab;
    public Camera cam;

   

    // Update is called once per frame
    void Update()
    {

        Vector2 gazePoint = TobiiAPI.GetGazePoint().Screen;

        Vector3 throwpoint = cam.ScreenToWorldPoint(new Vector3(gazePoint.x, gazePoint.y, cam.nearClipPlane));
        if (Input.GetKeyDown("j"))
        {
            ThrowGrenade(throwpoint);
        }
        
    }
       
    void ThrowGrenade(Vector3 throwing)
    {
        GameObject grenade = Instantiate(grenadePrefab, throwing , cam.transform.rotation);
        Rigidbody rb = grenade.GetComponent<Rigidbody>();
        rb.AddRelativeForce(transform.forward * throwForce, ForceMode.VelocityChange);
    }
}
