using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    //If in a collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Checks if collision was with a player
        if (collision.gameObject.tag == "Player")
        {
            //Changes static value of which level, the player is on
            LevelNumber.playerLevel++;

            //Loads the next level
            SceneManager.LoadScene("Level " + LevelNumber.playerLevel);
        }
    }
}
