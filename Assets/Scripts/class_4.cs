using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class class_4 : MonoBehaviour


#region 方法基本參數
#region 方法基本參數呼叫
//summary
//方法
//函式 函數 功能 
//function、method
{
    private void Awake()
    {
        //呼叫方法 : 方法沒有呼叫不會執行
        FirstFunction();
        FirstFunction();
        FirstFunction();
        //呼叫有參數的方法:小括號內放入引數
        //UseSkill(); //錯誤 少了引數
        UseSkill("死亡打擊", 50);
        //呼叫預設參數方法 (選填式參數
        SpawnEnemy();
        SpawnEnemy("巫妖王");

        Fire(700);
        Fire(600, "鋼珠");
        BuyItem();


        BuyItem(count: 30);

        BuyItem("藍水");

        BuyItem("藍水", 500000);
    }
    #endregion

    #region 方法
    //方法
    //包含一系列城市區塊
    //修飾詞:傳回資料類型 方法名稱 {程式區塊}
    //方法名稱
    //void 無傳回:使用此方法不會有傳回資料
    private void FirstFunction()
    {
        Debug.Log("第一個方法");
    }
    //參數語法 與區域變數相同 資料類型 參數名稱(習慣用小寫_開頭)
    private void UseSkill(string skill, float cost)
    {
        Debug.Log($"<color=#f93>施放技能:{skill}</color>");
        Debug.Log($"<color=#f93>技能消耗:{cost}</color>");
    }
    private void SpawnEnemy(string enemy = "哥布林")
    {
        Debug.Log($"<color=#f93>生成敵人:{enemy}</color>");
    }
    //選擇性參數要寫在右邊
    //private void Fire(string fire = "子彈", int speed)

    /// <summary>
    /// 發射物件方法
    /// </summary>
    /// <param name="speed">發射速度</param>
    /// <param name="fire">要發射物件</param>
    private void Fire(int speed, string fire = "子彈")
    {
        Debug.Log($"<color=#88f>發射物件:{fire},速度:{speed}</color>");
    }

    /// <summary>
    /// 購買物品
    /// </summary>
    /// <param name="item">道具名稱</param>
    /// <param name="count">道具數量</param>
    private void BuyItem(string item = "紅水", int count = 50)
    {
        Debug.Log($"<color=#77f>購買物品:{item},數量:{count}</color>");
    }

    #endregion
}
    #endregion

    //呼叫有傳回方法
    //第一種 把結果放到區域變數內 
    int unmber9 = Square(9);
    Debug.Log($"<color=#f97>9 的平方:{unmber9}</color");
//第二種把傳回方法當作該船回類型使用
Debug.Log($"<color=#88f>9 的平方{Square(7)}</color>");
//傳回方法: 傳回類型不是void 呼叫方法會獲得結果
//傳回方法必須在{}內使用return關鍵字將結果傳回

/// <summary>
/// 平方
/// </summary>
/// <param name="number">要平方的數字</param>
/// <returns>數字的平方</returns>
    private int Square(int number)
    {
        returrn number*number;
    }



