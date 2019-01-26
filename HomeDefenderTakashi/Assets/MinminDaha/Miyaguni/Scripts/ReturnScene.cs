using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnScene : MonoBehaviour
{
    public void OnReturnBuyBulletButtonOnClick()
    {
        SceneManager.LoadScene("BuyBullet");
    }
    
    public void OnReturnTitleButtonOnClick()
    {
        SceneManager.LoadScene("Title");
    }
}
