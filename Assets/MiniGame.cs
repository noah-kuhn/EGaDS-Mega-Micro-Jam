using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame : MonoBehaviour
{
    public enum GameTime
    {
        FourSeconds = 4, EightSeconds = 8
    }
    //******* ADD THESE IN THE INSPECTOR *******//
    public GameTime gameTime;
    public AudioClip music;
    //*****************************************//
    
    //******* UPDATE THIS WHEN THE PLAYER WINS *******//
    public bool gameWin;
    //***********************************************//
    private void Awake()
    {
        GameManager.instance.onMinigameStart();
        StartCoroutine(GameTimer());
    }

    private IEnumerator GameTimer()
    {
        yield return new WaitForSeconds((int) gameTime);
        GameManager.instance.onMinigameEnd(gameWin);
        //TODO: Add stuff
    }
    
    
    
}
