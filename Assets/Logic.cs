using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class StartButtons : MonoBehaviour
{

    public GameObject Settings;
    public void Quit() 
    {
        Application.Quit();
    }

    public void ToGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void ToUpgrades() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void SettingsScreen()
    {
        if (Settings != null)
        {
            bool isActive = Settings.activeSelf;
            Settings.SetActive(!isActive);
        }
    }
}
