using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu Lvl");
    }
    public void CloseGame ()
    {
        Application.Quit();
    }
    public void Lvl1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("lvl 1");
    }
    public void Lvl2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Lvl 2");
    }
    public void Lvl3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Lvl 3");
    }
    public void Back ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
