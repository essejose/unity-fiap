﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScript : MonoBehaviour {

    public static bool inGame;
    public static bool endGame;
    // Update is called once per frame
    void Update () {

            if (!inGame && Input.GetButtonDown("Fire1") && !endGame)
            {
                    inGame = true;
                     SceneManager.LoadScene("game");
             }
        }
}
