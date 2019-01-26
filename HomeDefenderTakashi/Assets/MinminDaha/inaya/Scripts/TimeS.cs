using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class TimeS : MonoBehaviour {
    private float time = 60;
    //public ballScript BallScript;
    Text timerText;
    void Start()
    {
        //初期値60を表示
        //float型からint型へCastし、String型に変換して表示
        timerText = gameObject.GetComponent<Text>();
        timerText.text = ((int)time).ToString();
    }
    void Update()
    {
        //1秒に1ずつ減らしていく
        time -= Time.deltaTime;
        //マイナスは表示しない
        if (time < 0) time = 0;
        timerText.text = ((int)time).ToString();


        if (time <= 0)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }



}
