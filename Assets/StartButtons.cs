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
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void ToGame()
    {
        Debug.Log("This should switch to the game scene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void ToUpgrades() 
    {
        Debug.Log("This should switch to the upgrade scene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void SettingsScreen()
    {
        Debug.Log("This should open the settings panel");
        if (Settings != null) 
        {
            bool isActive = Settings.activeSelf;
            Settings.SetActive(!isActive);
        }
        
    }
}
