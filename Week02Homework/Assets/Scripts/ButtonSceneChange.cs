using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSceneChange : MonoBehaviour
{

  public void IntroButton() //function to use on click event 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Load Scene through getting the current scene and continuing by 1 in the build settings index
    }
  
    public void FinalButton() //function to use on click event 
    {
        SceneManager.LoadScene("Introduction"); // Load Scene through getting the current scene and continuing by 1 in the build settings index
    }
}
