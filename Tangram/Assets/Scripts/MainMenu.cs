using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void Developers()
    {
        SceneManager.LoadScene("Developers");
    }
    public void Help()
    {
        SceneManager.LoadScene("Help");
    }

    public void Easy_1()
    {
        SceneManager.LoadScene(4);
    }

    public void Easy_2()
    {
        SceneManager.LoadScene(5);
    }
    public void Easy_3()
    {
        SceneManager.LoadScene(6);
    }
    public void Medium_1()
    {
        SceneManager.LoadScene(7);
    }
    public void Medium_2()
    {
        SceneManager.LoadScene(8);
    }
    public void Medium_3()
    {
        SceneManager.LoadScene(9);
    }
    public void Hard_1()
    {
        SceneManager.LoadScene(10);
    }
    public void Hard_2()
    {
        SceneManager.LoadScene(11);
    }
    public void Hard_3()
    {
        SceneManager.LoadScene(12);
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void ExitGame()
    {
        Debug.Log("Oyundan çýkýþ yapýldý.");
        Application.Quit();
    }

    
}
