using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // Variable to store the previous scene index
    private static int previousSceneIndex = -1;
    [SerializeField]
    public float FadeOutTime = 2.0f;

    public void GoToPreviousScene()
    {
        if (previousSceneIndex != -1)
        {
            Invoke("LoadPreviousScene", FadeOutTime);
        }
        else
        {
            UnityEngine.Debug.Log("No previous scene to go back to.");
        }
    }

    // Method to set the previous scene index
    public void SetPreviousScene()
    {
        previousSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    
    public void SetPreviousScene(int sceneIndex)
    {
        previousSceneIndex = sceneIndex;
    }

    public void GoToStartScene()
    {
        SetPreviousScene();
        Invoke("LoadStartScene", FadeOutTime);
    }

    public void GoToBoneyard()
    {
        SetPreviousScene();
        Invoke("LoadBoneyard", FadeOutTime);
    }

    public void GoToSeymourLake()
    {
        SetPreviousScene();
        Invoke("LoadSeymour", FadeOutTime);
    }

    public void GoToRiverside()
    {
        SetPreviousScene();
        Invoke("LoadRiverside", FadeOutTime);
    }

    public void GoToAnnacis()
    {
        SetPreviousScene();
        Invoke("LoadAnnacis", FadeOutTime);
    }

    public void GoToBurns()
    {
        SetPreviousScene();
        Invoke("LoadBurns", FadeOutTime);
    }

    public void GoToReworld()
    {
        SetPreviousScene();
        Invoke("LoadReworld", FadeOutTime);
    }

    public void GoToGrouse()
    {
        SetPreviousScene();
        Invoke("LoadGrouse", FadeOutTime);
    }

    public void GoToVideoBoneyard()
    {
        SetPreviousScene();
        Invoke("LoadVideoBoneyard", FadeOutTime);
    }

    public void GoToVideoSeymourLake()
    {
        SetPreviousScene();
        Invoke("LoadVideoSeymourLake", FadeOutTime);
    }

    public void GoToVideoRiverside()
    {
        SetPreviousScene();
        Invoke("LoadVideoRiverside", FadeOutTime);
    }

    public void GoToVideoAnnacis()
    {
        SetPreviousScene();
        Invoke("LoadVideoAnnacis", FadeOutTime);
    }

    public void GoToVideoBurns()
    {
        SetPreviousScene();
        Invoke("LoadVideoBurns", FadeOutTime);
    }

    public void GoToVideoReworld()
    {
        SetPreviousScene();
        Invoke("LoadVideoReworld", FadeOutTime);
    }

    public void GoToEndScreen()
    {
        SetPreviousScene();
        Invoke("LoadEndScreen", FadeOutTime);
    }

    public void GoToVideoGrouse()
    {
        SetPreviousScene();
        Invoke("LoadVideoGrouse", FadeOutTime);
    }

    void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
    void LoadBoneyard()
    {
        SceneManager.LoadScene(1);
    }
    void LoadSeymour()
    {
        SceneManager.LoadScene(2);
    }
    void LoadRiverside()
    {
        SceneManager.LoadScene(3);
    }
    void LoadAnnacis()
    {
        SceneManager.LoadScene(4);
    }
    void LoadBurns()
    {
        SceneManager.LoadScene(5);
    }
    void LoadReworld()
    {
        SceneManager.LoadScene(6);
    }
    void LoadGrouse()
    {
        SceneManager.LoadScene(7);
    }
    void LoadVideoAnnacis()
    {
        SceneManager.LoadScene(8);
    }
      void LoadVideoBoneyard()
    {
        SceneManager.LoadScene(9);
    }
    void LoadVideoBurns()
    {
        SceneManager.LoadScene(10);
    }
    void LoadVideoReworld()
    {
        SceneManager.LoadScene(11);
    }
       void LoadVideoRiverside()
    {
        SceneManager.LoadScene(12);
    }
    void LoadVideoSeymourLake()
    {
        SceneManager.LoadScene(13);
    }
    void LoadVideoGrouse()
    {
        SceneManager.LoadScene(14);
    }
    void LoadEndScreen()
    {
        SceneManager.LoadScene(15);
    }
    void LoadPreviousScene(){
        SceneManager.LoadScene(previousSceneIndex);
    }
    

}
