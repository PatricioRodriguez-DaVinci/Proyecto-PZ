using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Cámara.
    public Transform cam;
           float vMouse;
           float hMouse;
           float yCamRotation = 0.0f;
    public float horizontalSpeed;
    public float verticalSpeed;

    // Movimiento.
    public CharacterController controller;
    public float   playerSpeed;
           float   x;
           float   z;
           Vector3 move;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        LookMouse();
        PlayerMove();
    }

    void LookMouse() // Mueve la cámara con el mouse.
    {
        hMouse = Input.GetAxis("Mouse X") * horizontalSpeed * Time.deltaTime;
        vMouse = Input.GetAxis("Mouse Y") * verticalSpeed   * Time.deltaTime;

        yCamRotation     -= vMouse;
        yCamRotation      = Mathf.Clamp(yCamRotation, -90f, 90f);
        transform.Rotate (0f, hMouse, 0f);
        cam.localRotation = Quaternion.Euler(yCamRotation, 0f, 0f);
    }

    void PlayerMove() // Mueve al personaje.
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        move = (transform.right * x) + (transform.forward * z);
        controller.Move(move * playerSpeed * Time.deltaTime);
    }

}
