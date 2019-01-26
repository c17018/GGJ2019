using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ★追加する（ポイント）
using UnityEngine.AI;

public class Chase : MonoBehaviour {

    GameObject target;
    GameDirector gameDirector;

    private NavMeshAgent agent;

    // Use this for initialization
    void Start () {
        //AudioSourceコンポーネントを取得し、変数に格納


        target = GameObject.FindWithTag("Coffee");
        agent = GetComponent<NavMeshAgent>();
        gameDirector = GameObject.FindWithTag("GameController").GetComponent<GameDirector>();
        agent.speed = gameDirector.EnemySpeed;
    }
	
	// Update is called once per frame
	void Update () {
        // ターゲットの位置を目的地に設定する。
        agent.destination = target.transform.position;
    }


}
