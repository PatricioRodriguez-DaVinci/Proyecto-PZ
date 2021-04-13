using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public Transform  cam;
           RaycastHit hit;
    public float      rayLength;
    public bool       isTouchingKeyObject;
    float             isTouchingKeyObjectTimer;

    void Start()
    {
        rayLength                = 3f;
        isTouchingKeyObject      = false;
        isTouchingKeyObjectTimer = 0f;
    }

    void Update()
    {
        // Chequea si estás haciendo click en la dirección a un objeto con
        // el tag "KeyObject" a cierta distancia y devuelve un flag, sino queda distancia 0.

        Physics.Raycast(cam.position, cam.forward, out hit, 0f);

        isTouchingKeyObjectTimer -= isTouchingKeyObjectTimer;

        if(isTouchingKeyObjectTimer <= 0)
        {
            isTouchingKeyObject = false;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.DrawRay(cam.position, cam.forward * rayLength, Color.red);

            if(Physics.Raycast(cam.position, cam.forward, out hit, rayLength))
            {
                if (hit.collider.tag == "KeyObject")

                {
                    isTouchingKeyObject = true;
                    Debug.Log("Touching");
                    isTouchingKeyObjectTimer = 1f;
                }

                else
                {
                    isTouchingKeyObject = false;
                    Debug.Log("NOTTouching");
                }
            }
            
        }

        // Fin del chequeo.
    }
}
