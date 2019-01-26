using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitWaveScene : MonoBehaviour
{
	void Start ()
    {
        Buy.Makura = 0;
        Buy.Money = 10000;
        GoStage.SetSceneName("Wave1");
	}

    public void OnStartButtonClick()
    {
        SceneManager.LoadScene("BuyBullet");
    }
}
