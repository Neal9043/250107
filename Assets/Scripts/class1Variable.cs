//單行註解、程式解釋、描述、作者資訊、不被程式執行
/*多行註解
 * 
 */

// 引用unity遊戲引擎函示庫
using Unity.VisualScripting;
using UnityEngine;

//修飾詞 (類別名稱、類別關鍵字
// 腳本後添加MonoBehaviour 可讓腳本掛在unity
public class class1Variables : MonoBehaviour

{
    //程式內的括號都是成對出現 () [] {} '' ""
    // class {} 此類別的程式內容

    // 變數:會改變得數值，用來存放遊戲內資訊
    // 例如:LOL隨遊戲時間自動增加金錢
    //定義一個記憶體內的空間用存放資訊

    //變數語法:
    //變數資料類型 變數名稱;
    //變數資料類型 變數名稱 指定 預設值 ; - 可省略
    //資料類型:告訴記憶體可放那些資料,例如整數int
    //變數名稱;習慣用小寫命名,規則與腳本名稱相同
    //修飾詞 : 公開:允許其他類別讀取pubilc
    //私人 : private 禁止其他人讀取
    //int coin; 定義金幣變數

    public int coin = 500;
    private int level = 3;
}

