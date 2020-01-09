using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTimer : MonoBehaviour
{
   
   
    public float time = 3f; //30 seconds for you

    public void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            
            GetComponent<AudioSource>().Play();
        }
    }

        }
