using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
    public ActivatePuzzle myActivatePuzzle;
    public int            activatePuzzle;
    float                 _timerAux;
    int                   _thisPuzzleNumber;
    public PuzzlesManager myPuzzlesManager;
    public bool           startPuzzle1;
    bool                  _canActivate;

    void Start()
    {
        _thisPuzzleNumber = 1; // Éste es el número del puzzle que queremos activar.

        startPuzzle1      = false;
        activatePuzzle    = 0;
        _timerAux         = 0f;
        _canActivate      = true;
    }

    void Update() // Verifica que se den las condiciones para ejecutar el Puzzle del número elegido.
    {
        _timerAux -= Time.deltaTime;

        if (_timerAux <= 0)
        {
            activatePuzzle  = 0;
            startPuzzle1    = false;
            _canActivate    = true;
        }

        if (myActivatePuzzle.startPuzzle)
        {
            activatePuzzle = _thisPuzzleNumber;
            _timerAux = 1f;
        }

        if (myPuzzlesManager.playPuzzleNumber == _thisPuzzleNumber && _canActivate)
        {
            ActivateThisPuzzle();
        }
    }

    void ActivateThisPuzzle() // De acá en adelante, varía según el puzzle.
    {
        Debug.Log("Jugamos al Puzzle:1");
        startPuzzle1      = true;
        _timerAux         = 0.5f;
        _canActivate      = false;
    }
}
