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
        // float y = Random.Range(0.0f, 2.0f);
        float z = Random.Range(minSpawnPosZ, maxSpawnPosZ);
        Instantiate(cube, new Vector3(x, 0, z), Quaternion.identity);
        float xAbs;
        float zAbs;

        float maxR = Mathf.Pow(maxSpawnPosX, 2);
        float minR = Mathf.Pow(minSpawnPosX, 2);

        x = Random.Range(minSpawnPosX, maxSpawnPosX);
        z = Random.Range(minSpawnPosZ, maxSpawnPosZ);

        xAbs = Mathf.Abs(Mathf.Pow(x, 2));
        zAbs = Mathf.Abs(Mathf.Pow(z, 2));

        // 特定の範囲内か確認
        if (maxR > xAbs + zAbs && xAbs + zAbs > minR)
        {
            GameObject go = Instantiate(
                enemys[0],             // 個体のオブジェクト
                (new Vector3(x, 0.5f, z)) + Vector3.zero,        // 初期座標
                Quaternion.identity         // 回転位置
                );
        }

        numberOfEnemys++;
        elapsedTime = 0f;
    }

}

//[Header("分布")]
//[SerializeField] Transform CenterPosition;                 // 対象オブジェクト
//[SerializeField] int ArrangementMaxRedius = 1000;         // 配置位置の最大半径
//[SerializeField] int ArrangementMinRedius = 500;         // 配置位置の最小半径
//[SerializeField] int ArrangementHeight = 10;              // 配置位置の高さ


//[Header("個数")]
//[SerializeField] GameObject CreaturePrefab;                 // 対象オブジェクト
//[SerializeField] int CreatureLength = 100;                 // 配置位置の最大


//private System.Random random;                               // 乱数機

//// Use this for initialization
//void Start()
//{

//    GameObject[] CreatureRange = new GameObject[CreatureLength];

//    int x;
//    int z;

//    float xAbs;
//    float zAbs;

//    float maxR = Math.Pow(ArrangementMaxRedius, 2);
//    float minR = Math.Pow(ArrangementMinRedius, 2);

//    for (int i = 0; i < CreatureRange.Length; i++)
//    {
//        while (CreatureRange[i] == null)
//        {
//            x = Random.Range(-ArrangementMaxRedius, ArrangementMaxRedius);
//            z = Random.Range(-ArrangementMaxRedius, ArrangementMaxRedius);

//            xAbs = Math.Abs(Math.Pow(x, 2));
//            zAbs = Math.Abs(Math.Pow(z, 2));

//            // 特定の範囲内か確認
//            if (maxR > xAbs + zAbs && xAbs + zAbs > minR)
//            {
//                GameObject go = Instantiate(
//                    CreaturePrefab,             // 個体のオブジェクト
//                    (new Vector3(x, ArrangementHeight, z)) + Vector3.zero,        // 初期座標
//                    Quaternion.identity         // 回転位置
//                );
//                CreatureRange[i] = go;
//            }
//        }
//    }

//}
