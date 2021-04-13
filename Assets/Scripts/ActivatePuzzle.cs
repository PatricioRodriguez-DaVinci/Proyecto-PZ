using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePuzzle : MonoBehaviour
{
    public PlayerActions myPlayerActions;
    public bool          isTouchingKeyObject;
    public bool          isPlayerNear;
    public bool          startPuzzle;
    public float                _timerAux;


    // Start is called before the first frame update
    void Start()
    {
        isTouchingKeyObject = false;
        isPlayerNear        = false;
        startPuzzle         = false;
        _timerAux           = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingKeyObject = myPlayerActions.isTouchingKeyObject;

        _timerAux -= Time.deltaTime;

        if (_timerAux <= 0)
        {
            startPuzzle = false;
        }

        if (isPlayerNear && isTouchingKeyObject)
        {
            StartPuzzle();
        }

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            isPlayerNear = true;
            Debug.Log("Entra");
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            isPlayerNear = false;
            startPuzzle  = false;
            Debug.Log("Sale");
        }
    }

    void StartPuzzle()
    {
        Debug.Log("Iniciar Puzzle");
        startPuzzle = true;
        _timerAux = 0f;
    }
}
