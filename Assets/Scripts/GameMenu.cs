﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public void RestartBtn()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitBtn()
    {
        Application.Quit();
    }

}
