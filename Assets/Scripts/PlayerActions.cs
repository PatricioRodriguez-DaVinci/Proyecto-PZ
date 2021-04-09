using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public Transform  cam;
           RaycastHit hit;
    public float      rayLength;

    // Start is called before the first frame update
    void Start()
    {
        rayLength = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        Physics.Raycast(cam.position, cam.forward, out hit, 0f);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.DrawRay(cam.position, cam.forward * rayLength, Color.red);

            if(Physics.Raycast(cam.position, cam.forward, out hit, rayLength))
            {
                if (hit.collider.tag == "KeyObject")

                    Debug.Log("Activar objeto");

                if (Input.GetKeyDown(KeyCode.E))

                    Debug.Log("Se está usando el objeto");
            }
        }
    }
}
