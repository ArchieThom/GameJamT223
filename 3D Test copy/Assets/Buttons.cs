using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject pauseButton;
    public GameObject deathScreen;

    public void Play()
    {
        SceneManager.LoadScene("Main");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Pause()
    {
        Time.timeScale = 0;
        pauseScreen.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Death()
    {
        Time.timeScale = 0;
        deathScreen.SetActive(true);
        pauseButton.SetActive(false);
    }
}
