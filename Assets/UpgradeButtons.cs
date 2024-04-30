using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpgradeButtons : MonoBehaviour
{
    public GameObject UpgradeUI;
    public GameObject Gear;
    public GameObject Launchers;
    public void BackToMain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void ToFlying() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if (UpgradeUI != null) 
        {
            bool isActive = UpgradeUI.activeSelf;
            UpgradeUI.SetActive(!isActive);
        }
    }
    public void GearScreen()
    {
        if (Gear != null)
        {
            bool isActive = Gear.activeSelf;
            Gear.SetActive(!isActive);
            Launchers.SetActive(!Launchers.activeSelf);
        }
    }
    public void LauncherScreen()
    {
        if (Launchers != null)
        {
            bool isActive = Launchers.activeSelf;
            Launchers.SetActive(!isActive);
            Gear.SetActive(!Gear.activeSelf);
        }
    }
}
