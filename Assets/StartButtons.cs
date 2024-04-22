using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
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
=======

public class StartButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
>>>>>>> ebe7dc3c0cdbf2b730d506609bca6e775b66e287
        
    }
}
