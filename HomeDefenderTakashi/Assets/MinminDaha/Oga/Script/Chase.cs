using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ★追加する（ポイント）
using UnityEngine.AI;

public class Chase : MonoBehaviour {

    public GameObject target;
    private NavMeshAgent agent;

    // Use this for initialization
    void Start () {
        target = GameObject.FindWithTag("Coffee");
        agent = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        // ターゲットの位置を目的地に設定する。
        agent.destination = target.transform.position;
    }
}
