using System.Diagnostics.Contracts;
using UnityEngine;
public class 練習_1_變數 : MonoBehaviour
{
    // 公開變數
    public int 價格 = 999;

    // 私人變數
    private float 跳躍高度 = 77.5f;

    // 公開陣列變數
    public string 武器預設值 = "三項之力";

    // 私人布林變數
    private bool 是否獲得龍魂 = true;

    void Start()
    {
        Debug.Log($"價格: {價格}");
        Debug.Log($"跳躍高度: {跳躍高度}");
        Debug.Log($"武器: {string.Join(", ", 武器預設值)}");
        Debug.Log($"是否獲得龍魂: {是否獲得龍魂}");
    }
}
