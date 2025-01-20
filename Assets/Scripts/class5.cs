using Unity.VisualScripting;
using UnityEngine;

///命名空間:
///將類別分類,類似倉庫的概念
///語法 namespace 命名空間名稱 {內容}
namespace MyNamespace
{
    /// <summary>
    /// 選取陳述式
    /// 1. if 判斷式
    /// 2.switch 判斷式
    /// </summary>
    public class class5 : MonoBehaviour
    {
        [SerializeField, Header("武器")]
        private string weapon;

        #region 判斷式

        private void Awake()
        {

            //更新事件:一分鐘執行60次 FPS(Frame Per Second)
            //if 判斷式
            //if 布林值(陳述式)
            if (true)
            {
                Debug.Log("當布林值為True，會執行這裡");
            }

            //快速完成:輸入if 選取if 陳述式按eneter 或 true
            if (false)
            {
                Debug.Log("當布林值為false，不會執行這裡。");
            }
        }

        #endregion

        #region 範例
        // 血量初始值
        public int health = 100;

        private void Update()
        {
            // 偵測血量變化並判斷
            CheckHealth(health);
        }
        /// <summary>
        /// 根據血量判斷玩家的狀態
        /// </summary>
        /// <param name="health">目前的血量</param>
        private void CheckHealth(int health)
        {
            if (health <= 0)
            {
                Debug.Log("<color=red>你已經死了</color>");
            }
            else if (health < 10)
            {
                Debug.Log("<color=red>快死掉了</color>");
            }
            else if (health < 40)
            {
                Debug.Log("<color=orange>警告，快喝水</color>");
            }
            else if (health < 60)
            {
                Debug.Log("<color=yellow>健康狀態有狀況</color>");
            }
            else if (health < 80)
            {
                Debug.Log("<color=green>血量安全</color>");
            }
            else
            {
                Debug.Log("<color=green>健康狀態良好</color>");
            }
        } 
        #endregion

    }
}
