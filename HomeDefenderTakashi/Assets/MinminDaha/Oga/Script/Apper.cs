﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apper : MonoBehaviour {
    //　出現させる敵を入れておく
    [SerializeField] GameObject[] enemys;
    //　次に敵が出現するまでの時間
    [SerializeField] float appearNextTime;
    //　この場所から出現する敵の数
    [SerializeField] int maxNumOfEnemys;
    //　今何人の敵を出現させたか
    private int numberOfEnemys;
    //　待ち時間計測フィールド
    private float elapsedTime;

    public GameObject cube;

    [SerializeField] private float minSpawnPosX;
    [SerializeField] private float maxSpawnPosX;

    [SerializeField] private float minSpawnPosZ;
    [SerializeField] private float maxSpawnPosZ;

    // Use this for initialization
    void Start()
    {
        //オブジェクトを生産
        numberOfEnemys = 0;
        elapsedTime = 0f;
        AppearEnemy();
    }

    void Update()
    {
       
        //　この場所から出現する最大数を超えてたら何もしない
        if (numberOfEnemys >= maxNumOfEnemys)
        {
            return;
        }
        //　経過時間を足す
        elapsedTime += Time.deltaTime;

        //　経過時間が経ったら
        if (elapsedTime > appearNextTime)
        {
            elapsedTime = 0f;

            AppearEnemy();
        }
    }

    //　敵出現メソッド
    void AppearEnemy()
    {
        float x = Random.Range(minSpawnPosX, maxSpawnPosX);
        float spawnXPos = x > 0.0f ? maxSpawnPosX : minSpawnPosX;
        float z = Random.Range(minSpawnPosZ, maxSpawnPosZ);
        float spawnZPos = z > 0.0f ? maxSpawnPosZ : minSpawnPosZ;

        Instantiate(enemys[Random.Range(0, enemys.Length)], new Vector3(spawnXPos, 0, spawnZPos), Quaternion.identity);
        numberOfEnemys++;
        elapsedTime = 0f;
    }

}