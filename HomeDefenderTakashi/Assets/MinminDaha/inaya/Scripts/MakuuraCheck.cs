using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class MakuuraCheck : MonoBehaviour {

    public Text Makuratext;
    public int textmoney;
    // Use this for initialization
    Buy makurapoint;
    void Start()
    {
        makurapoint = FindObjectOfType<Buy>();
        textmoney = Buy.MakuraPoint;
        Makuratext.text = "マクラ残数"　+ textmoney.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //textMoney = Buy.GetMakuraPoint();
        //Makuratext.text = "マクラ残数"　+ textMoney.ToString();
        textmoney = Buy.MakuraPoint;
        Makuratext.text = "マクラ残数" + textmoney.ToString();
        //}

    }
}
