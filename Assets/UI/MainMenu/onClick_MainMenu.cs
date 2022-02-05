using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onClick_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Opition;
    public GameObject Exit;
    public GameObject RS;
    public void Opition_in()
    {
        MainMenu.SetActive(false);
        Exit.SetActive(false);
        Opition.SetActive(true);
        RS.SetActive(false);
    }
    public void Opition_out()
    {
        MainMenu.SetActive(true);
        Exit.SetActive(false);
        Opition.SetActive(false);
        RS.SetActive(false);
    }
    public void Exit_in()
    {
        MainMenu.SetActive(false);
        Exit.SetActive(true);
        Opition.SetActive(false);
        RS.SetActive(false);
    }
    public void Exit_out()
    {
        MainMenu.SetActive(true);
        Exit.SetActive(false);
        Opition.SetActive(false);
        RS.SetActive(false);
    }
    public void RS_in()
    {
        MainMenu.SetActive(false);
        Exit.SetActive(false);
        Opition.SetActive(false);
        RS.SetActive(true);
    }
    public void RS_out()
    {
        MainMenu.SetActive(false);
        Exit.SetActive(false);
        Opition.SetActive(true);
        RS.SetActive(false);
    }
    public static void OnApplicationQuit()
    {
        Application.Quit();
    }
    public static void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
