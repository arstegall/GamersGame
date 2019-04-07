using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_control : MonoBehaviour
{
    //glavne tipke u meniju
    public GameObject play;
    public GameObject help;
    public GameObject exit;
    public GameObject lvlSelect;

    //tipka za povratak
    public GameObject back;

    //prikaz help menija
    public GameObject help_prikaz;

    //tipke za izbor levela
    public GameObject lvlKnjiznica;
    public GameObject lvlHodnik;
    public GameObject lvlKampus;
    

    void Start()
    {
        play.SetActive(true);
        help.SetActive(true);
        exit.SetActive(true);
        lvlSelect.SetActive(true);
        back.SetActive(false);
        help_prikaz.SetActive(false);
        lvlKnjiznica.SetActive(false);
        lvlHodnik.SetActive(false);
        lvlKampus.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.lockState = CursorLockMode.None;
    }

    public void playGame()
    {
        SceneManager.LoadScene(4);
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void backOption()
    {
        Start();
    }

    public void helpPrikaz()
    {
        help_prikaz.SetActive(true);
        play.SetActive(false);
        help.SetActive(false);
        exit.SetActive(false);
        lvlSelect.SetActive(false);
        lvlKnjiznica.SetActive(false);
        lvlHodnik.SetActive(false);
        lvlKampus.SetActive(false);
        back.SetActive(true);
    }

    public void lvlSelector()
    {
        help_prikaz.SetActive(false);
        play.SetActive(false);
        help.SetActive(false);
        exit.SetActive(false);
        lvlSelect.SetActive(false);
        lvlKnjiznica.SetActive(true);
        lvlHodnik.SetActive(true);
        lvlKampus.SetActive(true);
        back.SetActive(true);
    }

    public void playKniznica()
    {
        SceneManager.LoadScene(1);
    }

    public void playHodnik()
    {
        SceneManager.LoadScene(5);
    }

    public void playKampus()
    {
        SceneManager.LoadScene(7);
    }

}
