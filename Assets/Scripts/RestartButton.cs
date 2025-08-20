using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    //Method for restarting the game once dead.
    public void OnButtonClicked()
    {
        //Loads first level
        SceneManager.LoadScene("Level 1");
    }
}
