using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu_script : MonoBehaviour
{
    public void CheckpointRace()
    {
        SceneManager.LoadScene("CheckpointRaceDialogue");
        SFXManager.instance.PlaySound("menu_click");
    }

    public void BeginnerRace()
    {
        SceneManager.LoadScene("BeginnerRaceDialogue");
        SFXManager.instance.PlaySound("menu_click");
    }

    public void AdvancedRace()
    {
        SceneManager.LoadScene("AdvancedRaceDialogue");
        SFXManager.instance.PlaySound("menu_click");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
