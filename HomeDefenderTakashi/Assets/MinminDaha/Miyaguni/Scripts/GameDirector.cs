using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    [SerializeField] private float enemySpeed;

    public float EnemySpeed
    {
        // set { enemySpeed = value; }
        get { return enemySpeed; }
    }
}
