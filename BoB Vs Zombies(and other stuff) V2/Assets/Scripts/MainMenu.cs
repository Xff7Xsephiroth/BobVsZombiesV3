using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
    
{
    public Button newGameButton;

    public Button highScoreButton;

    public Button exitGameButton;

    public string newGameSceneName;

    public void NewGame()
    {
        SceneManager.LoadScene(Zombie,Shooter,Level,1);

    }

    public void HighScore()
    {


    }
        
        
    public void ExitGame()
    {

        Application.Quit();
    }







    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
