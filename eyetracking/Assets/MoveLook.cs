using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLook : MonoBehaviour
{
    //public GameObject Lookat;
    //public Collider col;
    // Start is called before the first frame update
    void Start()
    {
       // Lookat.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Looking")
        {
            Debug.Log("looking");
        }
    }
}
