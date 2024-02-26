using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [Header("MainMenu")]
    public GameObject menu;

    [Header("Options")]
    public GameObject optionsPanel;
    public Button backButton;

    [Header("Credits")]
    public GameObject creditsPanel;
    public Button backButton1;

    private void Start()
    {
        optionsPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }
    public void Credits()
    {
        creditsPanel.SetActive(true);
        menu.SetActive(false);
    }

    public void Options()
    {
        optionsPanel.SetActive(true);
        menu.SetActive(false);
    }

    public void Back()
    {
        optionsPanel.SetActive(false);
        creditsPanel.SetActive(false);
        menu.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
