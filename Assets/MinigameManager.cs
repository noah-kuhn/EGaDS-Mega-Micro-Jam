using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//******** CHANGE THIS TO YOUR TEAM'S NAMESPACE *********//
namespace TEAM_NAME_SPACE 
//******************************************************//
{
    public class MinigameManager : MonoBehaviour
    {
        //******* FOR DEBUGGING *******//
        public bool debugGameOnly; // set to true if you want to test your scene alone in play mode;
        //****************************//

        public Minigame minigame;
        
        
        

        
        public void PlaySound(string soundName)
        {
            foreach (var s in minigame.sounds)
            {
                if (s.soundName == soundName)
                {
                    s.source.Play();
                }
            }
        }
        
        
        
        
        
        private AudioSource musicSource;


        private void Awake()
        {
            if (!(debugGameOnly && GameManager.instance == null))
            {
                GameManager.instance.onMinigameStart(minigame);
            }

            musicSource = gameObject.AddComponent<AudioSource>();
            musicSource.clip = minigame.music;
            foreach (var s in minigame.sounds)
            {
                s.source = gameObject.AddComponent<AudioSource>();
                s.source.clip = s.clip;
                s.source.volume = s.volume;
            }

            musicSource.Play();
        }

    }
}
