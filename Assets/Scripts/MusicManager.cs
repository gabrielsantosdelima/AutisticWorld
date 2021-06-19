using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    
    public void desmutar()
    {
        GameObject audioSourceGameObject = GameObject.Find("Music");
        AudioSource source = audioSourceGameObject.GetComponent<AudioSource>();
        source.volume = 1;
    }
    public void mutar()
    {
        GameObject audioSourceGameObject = GameObject.Find("Music");
        AudioSource source = audioSourceGameObject.GetComponent<AudioSource>();
        source.volume = 0;
    }

 
}
