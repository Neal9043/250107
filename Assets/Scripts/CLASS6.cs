using UnityEngine;

public class CLASS6 : MonoBehaviour
{
    private void Awake()
    {
        // 迴圈在一次性事件內使用 Awake、Start
        // while 迴圈 : 布林為ture 會持續執行
        // while (布林直) (程式區塊)
        // 無限迴圈 : 布林一直都是ture
        // 宣告區域變數 i 為 0
        int i = 0;
        // 當 i < 5 就執行{}

        while (i < 5)
        {
            Debug.Log("<color=#f44>while 迴圈, i :{i]</color");
            // i 遞增(i+1) 
            i++;
        }
    }
}
