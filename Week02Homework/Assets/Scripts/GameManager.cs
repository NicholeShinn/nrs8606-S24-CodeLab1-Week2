using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //static means that there's one instance of this variable, no matter how many exist. If something changes, it changes for every instance.
    public int score = 0;
    public int targetScore = 6;
    public TextMeshProUGUI scoreText;
    
    //singletons should appear in awake over start, so that there's no weird errors. It can run initially, over first frame
    private void Awake()
    {
        if (instance == null) // if the instance hasn't been set
        {
            instance = this; // then set the instance to this one (game manager)
            DontDestroyOnLoad(gameObject); //specifying the object this code is attached to 
        }
        else // if there is already a singleton of it's type, you must destroy the game object this is attached to
        {
            Destroy(gameObject);
        }
    }
    
    void Update()
    {
        scoreText.text = "Satellites Killed: " + score;

        // When target score is reached, move on to the next scene
        if (score == targetScore)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Load Scene through getting the current scene and continuing by 1 in the build settings index
            //SceneManager.LoadScene("Level2"); //Load Scene through targeting a specific scene's name in the index
            
            targetScore = Mathf.RoundToInt (targetScore + targetScore * 0.5f); // bumping up the target score to a consistent growth curve, relative to the original target score round to Int, rounds to closest integer
        }
        
    }
}
