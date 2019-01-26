using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class MoneyCheck : MonoBehaviour {


    public Text Moneytext;
    int textMoney = Buy.GetMoneyPoint();
    // Use this for initialization
    void Start () {

        textMoney = Buy.GetMoneyPoint();
        Moneytext.text = "残金" + textMoney.ToString() + "円";
    }
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetMouseButtonDown(0))
        //{
            textMoney = Buy.GetMoneyPoint();
            Moneytext.text = "残金" + textMoney.ToString() + "円";

       //}

    }
}
