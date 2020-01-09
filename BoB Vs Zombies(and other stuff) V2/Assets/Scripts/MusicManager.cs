using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public void Music()
    
    {

        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.PlayDelayed(10);
    }

}
