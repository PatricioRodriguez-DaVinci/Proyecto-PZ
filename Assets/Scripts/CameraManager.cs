using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera  mainCamera;
    public Camera  camPuzzle1;
    public bool    canPlayerMove;
    public Puzzle1 myPuzzle1;
    float _timer;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = true;
        camPuzzle1.enabled = false;
        canPlayerMove      = true;
        _timer             = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;

        if ((Input.GetKeyDown(KeyCode.C) || myPuzzle1.startPuzzle1) && _timer <= 0)
        {
            canPlayerMove = !canPlayerMove;

            mainCamera.enabled = !mainCamera.enabled;
            camPuzzle1.enabled = !camPuzzle1.enabled;

            _timer = 2f;
        }
    }
}
