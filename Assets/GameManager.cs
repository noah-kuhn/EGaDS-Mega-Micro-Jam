using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.WSA;
using Random = UnityEngine.Random;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private const int StartingLives = 3;
    private int remainingLives;
    public int numberOfGames;
    private List<string> remainingGames = new List<string>();

    private const float ShortTime = 3.4f;
    private const float LongTime = 6.8f;

    public Canvas canvas;
    public float startWaitTime;
    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        for(int i = 1; i<=numberOfGames;i++) remainingGames.Add(i.ToString());
        StartCoroutine(LoadFirstGame()); //TODO: replace with title screen stuff
    }

    private void ManageMainScene()
    {
        
    }

    private IEnumerator LoadFirstGame()
    {
        yield return new WaitForSeconds(startWaitTime);
        SceneManager.LoadScene(GetNextGame());
    }

    private IEnumerator LoadNextGame()
    {
        yield return new WaitForSeconds(4);
    }

    private string GetNextGame()
    {
        var i = Random.Range(0, remainingGames.Count-1);
        var scene = remainingGames[i];
        //remainingGames.Remove(game);
        return scene;
    }


    
    public void onMinigameStart(Minigame minigame)
    {
        var waitTime = minigame.gameTime == Minigame.GameTime.Short ? ShortTime : LongTime;
        StartCoroutine(WaitForMinigameEnd(minigame, waitTime));
    }

    private IEnumerator WaitForMinigameEnd(Minigame minigame, float time)
    {
        yield return new WaitForSeconds(time);

        SceneManager.LoadScene("Main");
        if (minigame.gameWin) remainingLives -= 1;
    }


}
