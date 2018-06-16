using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelChanger : MonoBehaviour {

    public Animator sceneAnimator;
    private int levelToLoad;
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            FadeToNextLevel();
        }
	}

    public void FadeToNextLevel()
    {
        FadeToNextLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToNextLevel (int levelIndex)
    {
        levelToLoad = levelIndex;
        sceneAnimator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
