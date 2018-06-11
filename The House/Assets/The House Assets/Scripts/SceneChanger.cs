﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {


	public void LoadScene()
	{
		SceneManager.LoadScene("Main");
	}
	public void BackBtn(string menuLevel)
	{
		//when the Start button is hit - Start Game
		SceneManager.LoadScene(menuLevel);
	}

	public void quitgame ()
	{
		//Debug.Log ("Quit");
		Application.Quit();
	}

}