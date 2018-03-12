using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void PlayMulti()
    {
        SceneManager.LoadScene("Multi");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
