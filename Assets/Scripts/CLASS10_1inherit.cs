using JetBrains.Annotations;
using TMPro;
using UnityEditor;
using UnityEngine;
public static class LogSystem
{
    public static void LogWithColor(string message, string color)
    {
        Debug.Log($"<color={color}>{message}</color>");
    }
}
public class CLASS10_1inherit : MonoBehaviour
{
    /// <summary>
    /// 繼承 inherit
    /// </summary>
    public void Awake()
    {
        var goblinl = new Goblin(10, 1);
        LogSystem.LogWithColor($"哥布林攻擊: {goblinl.attack}", "#f3d");

        var slimel = new Slime(3, 2);
        LogSystem.LogWithColor($"史萊姆攻擊: {slimel.attack}", "#3d");
        goblinl.Move();
        slimel.Move();
        slimel.Initlize();

        //判斷史萊母是否繼承哥步林
        //類別A is 類別B :布林直
        var slimelIsGolbin = slimel is Goblin;
        LogSystem.LogWithColor($"史萊母是否為哥布林:{slimelIsGolbin}", "#f33");

        var spiderl = new Spider(15, 3);
        var spiderlSlime = spiderl is Slime;
        var spiderlIsGobin = spiderl is Goblin;
        LogSystem.LogWithColor($"蜘蛛是否為史萊姆:{spiderlSlime}", "#f33");
        LogSystem.LogWithColor($"蜘蛛是否為哥布林:{spiderlIsGobin}", "#f33");
    }

    public class Goblin
    {
        public int attack;      //公開 : 所有類別可以存取
        public int defense;
        private float movespeed; //私人 : 此類別可以存取
        protected float hp;     //保護 : 子類別可以存取
        protected int lv = 5;

        public Goblin(int _attack, int _defense)
        {
            attack = _attack;
            defense = _defense;
        }
        // virtual 虛擬 : 允許子類別複寫
        public  virtual void Move()
        {
            LogSystem.LogWithColor("兩條腿移動", "#9f9");
        }
    }

    public class Slime : Goblin
    {
        protected int lv = 10; //綠色蚯蚓 :提示父類別有相同的成員名稱
        public Slime(int _attack, int _defense) : base(_attack, _defense)
        {
        }
    public void Initlize()
        {
            attack = 7;             //公開: 可以存取
            // moveSped = 3.5f;     //私人 : 無法存取
            hp = 10;                //保護 : 可以存取
            LogSystem.LogWithColor($"等級 :{lv}", "#18f");
            LogSystem.LogWithColor($"等級 :{base.lv}(父類別)", "#78f");
        }

        //overrride 覆寫:覆寫父類別有virtual 關鍵字的成員
        //override 選擇要覆寫的成員 > 按下enter 自動完成
        public override void Move()
        {
            //base.Move();      // 父類別有的內容
            LogSystem.LogWithColor("爬行", "#3f3");
        }
    }
    public class Spider : Slime
    {
        public Spider(int _attack, int _defense) : base(_attack, _defense)
        {
        }
    }
}
