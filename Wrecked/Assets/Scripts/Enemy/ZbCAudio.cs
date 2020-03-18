﻿using UnityEngine.Audio;
using System;
using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class ZbCAudio : MonoBehaviour
{
    public ZbCSounds[] sounds;
    private AudioSource ads;

    void Awake()
    {
        foreach (ZbCSounds s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;

        }

    }
    public void Play(string name)
    {
        //FindObjectOfType<AudioManager>().Play("ZbScream");  
        ZbCSounds s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();

    }
    // Update is called once per frame
    void Update()
    {

    }
}