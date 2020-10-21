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
    public string[] games; // This is where we will put the string names of every game in the inspector
    private List<string> nextGames = new List<string>();
        
    

    public Canvas canvas;
    public float startWaitTime;
    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        foreach (var s in games) nextGames.Add(s);
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
        int i = Random.Range(0, nextGames.Count - 1);
        string game = nextGames[i];
        //nextGames.Remove(game);
        return game;
    }

    public void onMinigameStart()
    {
        
    }

    public void onMinigameEnd(bool gameWin)
    {
        
    }


}
