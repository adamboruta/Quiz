using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject levelsPanel;
    [SerializeField] GameObject mainPanel;

    public void SelectLevel()
    {
        menuPanel.SetActive(false);
        levelsPanel.SetActive(true);
        
    }

    public void BackToMenu()
    {
        menuPanel.SetActive(true);
        levelsPanel.SetActive(false);
    }

    public void Klasa1()
    {
        SceneManager.LoadScene("1");
    }
    public void Klasa2()
    {
        SceneManager.LoadScene("2");
    }
    public void Klasa3()
    {
        SceneManager.LoadScene("3");
    }
    public void Klasa4()
    {
        SceneManager.LoadScene("4");
    }
    public void Klasa5()
    {
        SceneManager.LoadScene("5");
    }
    public void Klasa6()
    {
        SceneManager.LoadScene("6");
    }
    public void Klasa7()
    {
        SceneManager.LoadScene("7");
    }
    public void Klasa8()
    {
        SceneManager.LoadScene("8");
    }
}
