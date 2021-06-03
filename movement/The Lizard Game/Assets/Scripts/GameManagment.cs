using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagment : MonoBehaviour
{
    public GameObject menu;
    public GameObject Levelselect;
    public GameObject Info;

    public static bool won = false;
    private void Update()
    {
        if (won)
        {
            SceneManager.LoadScene("winner", LoadSceneMode.Single);
        }
    }

    public void StartGame()
    {
        Levelselect.SetActive(true);
        menu.SetActive(false);
    }

    public void Level_1()
    {
        SceneManager.LoadScene("Level-1", LoadSceneMode.Single);
    }

    public void Level_2()
    {
        SceneManager.LoadScene("Level-2", LoadSceneMode.Single);
    }

    public void Level_3()
    {
        SceneManager.LoadScene("Level-3", LoadSceneMode.Single);
    }

    public void Level_4()
    {
        SceneManager.LoadScene("Level-4", LoadSceneMode.Single);
    }

    public void GameInformation()
    {
        Info.SetActive(true);
        menu.SetActive(false);
    }

    public void Back()
    {
        Info.SetActive(false);
        Levelselect.SetActive(false);
        menu.SetActive(true);
    }

}
