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
public class CLASS1S : MonoBehaviour
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
    }

    public class Goblin
    {
        public int attack;      //公開 : 所有類別可以存取
        public int defense;
        private float movespeed; //私人 : 此類別可以存取
        protected float hp;     //保護 : 子類別可以存取

        public Goblin(int _attack, int _defense)
        {
            attack = _attack;
            defense = _defense;
        }
    }

    public class Slime : Goblin
    {
        public Slime(int _attack, int _defense) : base(_attack, _defense)
        {
        }
    public void Initlize()
        {
            attack = 7;             //公開: 可以存取
            // moveSped = 3.5f;     //私人 : 無法存取
            hp = 10;                //保護 : 可以存取
        }
    }
}
