using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlesManager : MonoBehaviour
{
    public Puzzle1 myPuzzle1;
    public Puzzle2 myPuzzle2;

    bool           doActivate;
    int            puzzleNumber;
    public int     playPuzzleNumber;
    float          timeToRestartPuzzleNumber;

    void Start()
    {
        timeToRestartPuzzleNumber = 0f;
        doActivate                = false;
        playPuzzleNumber          = 0;
        puzzleNumber              = 0;
    }

    void Update()
    {
        puzzleNumber     = 0;
        playPuzzleNumber = puzzleNumber;

        timeToRestartPuzzleNumber -= Time.deltaTime;

        if (timeToRestartPuzzleNumber <= 0)
        {
            puzzleNumber = 0;
        }

        if (myPuzzle1.activatePuzzle == 0 &&
            myPuzzle2.activatePuzzle == 0)
        {
            doActivate = false;
        }

        else
        {
            doActivate = true;
            AssignPuzzleNumber();
        }

        if(doActivate)
        {
            StartPuzzle();
        }
    }

    void AssignPuzzleNumber()
    {

        if (myPuzzle1.activatePuzzle != 0)
        {
            puzzleNumber = myPuzzle1.activatePuzzle;
        }

        if (myPuzzle2.activatePuzzle != 0)
        {
            puzzleNumber = myPuzzle2.activatePuzzle;
        }
    }

    void StartPuzzle()
    {
        playPuzzleNumber = puzzleNumber;

        if (playPuzzleNumber == 1)
        {
            doActivate = false;
        }

        else if (playPuzzleNumber == 2)
        {
            doActivate = false;
        }

        else Debug.Log("No deberías poder ver este mensaje");
    }

}
