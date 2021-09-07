using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPause;
    public GameObject pausedMenuUI;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPause = !isPause;
        }
        if(isPause)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }    
    public void Pause()
    {
        pausedMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
    }
    void Resume()
    {
        pausedMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPause = false;
    }
    public void ResetLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void NextLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {
        Debug.Log("This is QuitGame!");
        Application.Quit();
    }
}
