using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager: MonoBehaviour
{
    public GameObject settingsPanel;
    public void PlayGame()
    {
        Application.LoadLevel("selectmode");
    }

    public void RYANGOSLING()
    {
        Application.LoadLevel("selectpersryan");
    }

    public void Default()
    {
        Application.LoadLevel("selectpersdef");
    }

    public void kiryshadef()
    {
        Application.LoadLevel("kirdef");
    }

    public void astapadef()
    {
        Application.LoadLevel("astdef");
    }

    public void kirysharyan()
    {
        Application.LoadLevel("kirryan");
    }

    public void astaparyan()
    {
        Application.LoadLevel("astryan");
    }
    public void Pause()
    {
        Application.LoadLevel("menu");
        Destroy(GameObject.FindWithTag("Music"));
    }
    
    public void About()
    {
        Application.LoadLevel("about");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void SettingsPanel()
    {
        settingsPanel.SetActive(true);
    }

    public void Exit()
    {
        settingsPanel.SetActive(false);
    }
}