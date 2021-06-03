using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Game_Over()
    {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }

    public void Back()
    {
        SceneManager.LoadScene("Main_Menu", LoadSceneMode.Single); ;
    }

}
