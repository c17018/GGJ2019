using System.Collections;
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

    // Use this for initialization
    void Start()
    {
        //オブジェクトを生産
        numberOfEnemys = 0;
        elapsedTime = 0f;
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
        float x = Random.Range(-5.0f, 5.0f);
        float y = Random.Range(0.0f, 2.0f);
        float z = Random.Range(-5.0f, 5.0f);
        Instantiate(cube, new Vector3(x, y, z), Quaternion.identity);
        numberOfEnemys++;
        elapsedTime = 0f;
    }

}
