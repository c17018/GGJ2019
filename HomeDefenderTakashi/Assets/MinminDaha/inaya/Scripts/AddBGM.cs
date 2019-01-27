using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBGM : MonoBehaviour {

    private AudioSource battlesound01;

    void Start()
    {
        //AudioSourceコンポーネントを取得し、変数に格納
        battlesound01 = GetComponent<AudioSource>();

        battlesound01.PlayOneShot(battlesound01.clip);
    }

    void Update()
    {
        //指定のキーが押されたら音声ファイル再生
       
            //battlesound01.PlayOneShot(battlesound01.clip);

    }

}
