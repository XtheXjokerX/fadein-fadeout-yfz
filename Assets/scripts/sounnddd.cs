﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounnddd : MonoBehaviour
{

    public AudioClip level2Music;


    public AudioSource source;


    // Use this for initialization
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }


    void OnLevelWasLoaded(int level)
    {
        if (level == 2)
        {
            source.clip = level2Music;
            source.Play();
        }
    }
}
