using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public Transform  cam;
           RaycastHit hit;
    public float      rayLength;
    public bool       isTouchingKeyObject;

    void Start()
    {
        rayLength           = 3f;
        isTouchingKeyObject = false;
    }

    void Update()
    {
        // Chequea si estás haciendo click en la dirección a un objeto con
        // el tag "KeyObject" a cierta distancia y devuelve un flag, sino queda distancia 0.

        Physics.Raycast(cam.position, cam.forward, out hit, 0f);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.DrawRay(cam.position, cam.forward * rayLength, Color.red);

            if(Physics.Raycast(cam.position, cam.forward, out hit, rayLength))
            {
                if (hit.collider.tag == "KeyObject")

                    isTouchingKeyObject = true;

                    Debug.Log("Activar objeto");
            }
        }

        // Fin del chequeo.
    }
}
