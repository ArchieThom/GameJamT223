using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject pauseButton;
    public GameObject transition;

    public void Play()
    {
        SpriteRenderer render = transition.GetComponent<SpriteRenderer>();
        render.color = new Color32(0, 0, 0, 0);
        for (byte i = 0; i < 255; i += 10)
        {
            render.color = new Color32(0, 0, 0, i);
        }
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
}
