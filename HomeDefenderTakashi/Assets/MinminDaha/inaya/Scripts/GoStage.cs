using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoStage : MonoBehaviour
{
    [SerializeField] private static string SceneName;

    public static void SetSceneName(string sceneName)
    {
        SceneName = sceneName;
    }

    public void OnClick()
    {
        SceneManager.LoadScene(SceneName);
    }
}
