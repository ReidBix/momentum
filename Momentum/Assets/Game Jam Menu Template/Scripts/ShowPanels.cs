﻿using UnityEngine;
using System.Collections;

public class ShowPanels : MonoBehaviour {

	public GameObject optionsPanel;							//Store a reference to the Game Object OptionsPanel 
	public GameObject optionsTint;							//Store a reference to the Game Object OptionsTint 
	public GameObject menuPanel;							//Store a reference to the Game Object MenuPanel 
	public GameObject pausePanel;							//Store a reference to the Game Object PausePanel 
    public GameObject worldsPanel;
    public GameObject menuCamera;                                   //Store a reference to the UI canvas
    public GameObject endGamePanel;
    public GameObject creditsPanel;

    //Call this function to activate and display the Options panel during the main menu
    public void showCreditsPanel()
    {
        creditsPanel.SetActive(true);
        HideEndGamePanel();
        optionsTint.SetActive(true);
    }

    public void HideCreditsPanel()
    {
        creditsPanel.SetActive(false);
        optionsTint.SetActive(false);
    }
    public void ShowOptionsPanel()
	{
		optionsPanel.SetActive(true);
		optionsTint.SetActive(true);
	}

    public void showEndGamePanel()
    {
        endGamePanel.SetActive(true);
        optionsTint.SetActive(true);
    }

    public void HideEndGamePanel()
    {
        endGamePanel.SetActive(false);
        optionsTint.SetActive(false);
    }

    public bool endGameIsActive()
    {
        return endGamePanel.activeSelf;
    }

	//Call this function to deactivate and hide the Options panel during the main menu
	public void HideOptionsPanel()
	{
		optionsPanel.SetActive(false);
		optionsTint.SetActive(false);
	}
    public void ShowWorldsPanel()
    {
        worldsPanel.SetActive(true);
       // optionsTint.SetActive(true);
    }

    //Call this function to deactivate and hide the Options panel during the main menu
    public void HideWorldsPanel()
    {
        worldsPanel.SetActive(false);
       // optionsTint.SetActive(false);
    }

    //Call this function to activate and display the main menu panel during the main menu
    public void ShowMenu()
	{
		menuPanel.SetActive (true);
	}

	//Call this function to deactivate and hide the main menu panel during the main menu
	public void HideMenu()
	{
		menuPanel.SetActive (false);
        //UI.SetActive(false);
	}
	
	//Call this function to activate and display the Pause panel during game play
	public void ShowPausePanel()
	{
		pausePanel.SetActive (true);
		optionsTint.SetActive(true);
	}

	//Call this function to deactivate and hide the Pause panel during game play
	public void HidePausePanel()
	{
		pausePanel.SetActive (false);
		optionsTint.SetActive(false);

	}

    public void ShowMenuCamera()
    {
        menuCamera.SetActive(true);
    }

    public void HideMenuCamera()
    {
        menuCamera.SetActive(false);
    }
}
