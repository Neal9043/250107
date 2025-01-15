using System.Runtime.CompilerServices;
using UnityEngine;
//summary
//方法
//函式 函數 功能 
//function、method
public class class_4 : MonoBehaviour
{
    private void Awake()
    {
        //呼叫方法 : 方法沒有呼叫不會執行
        FirstFunction();
        FirstFunction();
        FirstFunction();
        //呼叫有參數的方法:小括號內放入引數
        //UseSkill(); //錯誤 少了引數
        UseSkill("死亡打擊");

    }

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
    private void UseSkill(string skill)
    {
        Debug.Log($"<color=#f93施放技能:{skill}</color>");
    }
}