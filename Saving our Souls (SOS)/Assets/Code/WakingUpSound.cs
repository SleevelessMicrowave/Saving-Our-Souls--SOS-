using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakingUpSound : MonoBehaviour
{
    public AudioSource source;
    
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    
    void Update() 
    {
        // play the sound
        source.Play();
    }

}