﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoStage : MonoBehaviour
{
    [SerializeField] private string SceneName;
    public void OnClick()
    {
        SceneManager.LoadScene(SceneName);
    }
}
