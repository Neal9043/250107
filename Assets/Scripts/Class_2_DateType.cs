using System.Diagnostics.Contracts;
using UnityEngine;

// 三條斜線是摘要 XML語言 用來做簡短說明
/// <summary>
/// 認識 C# 資料類型
/// </summary>
public class Class_2_DateType : MonoBehaviour
{
    //變數語法 :
    //修飾詞 資料類型 變數名稱 指定 預設值;
    //整數 : int 儲存沒有小數點的數值
    //浮點 : float 儲存有小數點的數值
    //字串 : string 儲存文字 必須使用雙引號
    //布林值  : bool 只有 true false 兩個詞
    public float moveSpeed = 3.5f; //浮點必須添加 f 後綴
    public float turnSpeed = 30.7F; //大小F都可
    public string character = "提摩";
    public bool isDead = false; //是否死亡;否
    public bool gameOver = true; //是否結束;是
    public int counnt = 7;

}
