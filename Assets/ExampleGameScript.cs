using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TEAM_NAME_SPACE{
    public class ExampleGameScript : MonoBehaviour
    {
        // DELETE THIS FILE BEFORE YOU SUBMIT //
        //...or at the very least, change the namespace//
        public Text UIText;
        public string startText;
        public string winText;
        private Minigame minigame;
        private void Start()
        {
            UIText.text = startText;
            minigame = FindObjectOfType<MinigameManager>().minigame;
        }

        private void Update()
        {
            if (Input.GetButtonDown("Space"))
            {
                if (!minigame.gameWin)
                {
                    minigame.gameWin = true;
                    UIText.text = winText;
                }
            }
        }
    }
}
