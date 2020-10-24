using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] music;


    private void Start()
    {
        var source = gameObject.AddComponent<AudioSource>();
        source.clip = music[Random.Range(0, music.Length-1)];
        source.Play();
    }
}
