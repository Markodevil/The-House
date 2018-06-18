using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelChanger : MonoBehaviour
{
    public float fadeTime = 2f;
    public Animator sceneAnimator;
    private int levelToLoad;

    // Update is called once per frame

    private void Start()
    {
        sceneAnimator = GetComponent<Animator>();
    }
    void Update ()
    {

	}

    public void FadeToQuit()
    {
        sceneAnimator.SetTrigger("FadeOut");
        Invoke("QuitGame", fadeTime);
    }

    public void FadeToStart()
    {
        sceneAnimator.SetTrigger("FadeOut");
        Invoke("StartGame", fadeTime);
    }

    public void FadeToReset()
    {
        sceneAnimator.SetTrigger("FadeOut");
        Invoke("ResetGame", fadeTime);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Has Quit");
    }
}
