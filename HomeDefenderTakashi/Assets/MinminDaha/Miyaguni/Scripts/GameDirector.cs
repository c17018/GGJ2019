using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    [SerializeField] private float[] enemySpeeds = new float[3];
    [SerializeField] private float enemySpeed;

    string activeSceneName;

    private void Start()
    {
        activeSceneName = SceneManager.GetActiveScene().name;
        switch(activeSceneName)
        {
            case "Wave1":
                enemySpeed = enemySpeeds[0];
                GoStage.SetSceneName("Wave2");
                break;
            case "Wave2":
                enemySpeed = enemySpeeds[1];
                GoStage.SetSceneName("Wave3");
                break;
            case "Wave3":
                enemySpeed = enemySpeeds[2];
                GoStage.SetSceneName("Wave1");
                break;
            default:
                break;
        }
    }

    public float EnemySpeed
    {
        // set { enemySpeed = value; }
        get { return enemySpeed; }
    }
}
