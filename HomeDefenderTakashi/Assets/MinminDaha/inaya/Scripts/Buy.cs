using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    public static int Money = 10000;
    public static int Makura = 0;
    public void OnClick()
    {
        if (Money >= 300)
        {
            Money = Money - 300;
            Makura = Makura + 1;
            Debug.Log(Money);
        }
        else
        {
            Debug.Log("購入できません");
            Debug.Log(Makura);
        }

    }
    public static int GetMoneyPoint()
    {
        return Money;
    }
    public static int MakuraPoint{
        set{
            Makura = value;;
        }
        get{
            return Makura;
        }
    }
}
