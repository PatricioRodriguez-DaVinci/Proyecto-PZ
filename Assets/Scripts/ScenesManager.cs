using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void ChangeToLevel0()
    {
        SceneManager.LoadScene("Level0");
        Debug.Log("Empezar a jugar");
    }

        public void CloseGame()
    {
        Application.Quit();
        Debug.Log("Closed");
    }
}
