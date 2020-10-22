using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SoundAsset
{
    public string soundName;
    public AudioClip clip;
    [Range(0, 1)] public float volume = 1;
    [HideInInspector] public AudioSource source;
}
