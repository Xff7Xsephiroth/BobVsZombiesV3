using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SetScore : MonoBehaviour
{
    public TextMeshProUGUI PlayerScore;
    
    // Start is called before the first frame update
   private void Start()
    {
        PlayerScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
