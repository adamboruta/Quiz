using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class adPanelScript : MonoBehaviour
{
    public void backToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
