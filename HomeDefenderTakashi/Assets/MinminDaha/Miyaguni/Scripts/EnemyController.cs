using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    private AudioSource battlesound02;
    void Start()
    {
        //AudioSourceコンポーネントを取得し、変数に格納
        battlesound02 = GetComponent<AudioSource>();

       
    }




    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Pillow")
        {
            AudioSource.PlayClipAtPoint(battlesound02.clip, Camera.main.transform.position);
            Destroy(gameObject);

        }
    }
}
