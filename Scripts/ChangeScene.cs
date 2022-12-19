using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{

    public void LoadActivityScene()
    {
        SceneManager.LoadScene("Activity Scene");
    }
    public void LoadLessonIDVessels()
    {
        SceneManager.LoadScene("Lesson ID Vessels");
    }
    public void LoadLessonLights()
    {
        SceneManager.LoadScene("Lesson 2");
    }
    public void LoadHome()
    {
        SceneManager.LoadScene("Home Screen");
    }
    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("App Ended");
    }
public void HomeScreen()
    {
        SceneManager.LoadScene("Welcome Screen");
    }

    public void LoadSailBoat()
    {
        SceneManager.LoadScene("Sailing Lights");
    }
    public void LoadPD1()
    {
        SceneManager.LoadScene("PowerDriven1");
    }
    public void LoadPD2()
    {
        SceneManager.LoadScene("PowerDriven2");
    }
    public void LoadPD3()
    {
        SceneManager.LoadScene("PowerDriven3");
    }
    public void LoadPD4()
    {
        SceneManager.LoadScene("PowerDriven4");
    }
    public void LoadVA()
    {
        SceneManager.LoadScene("VesselAnchored");
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
