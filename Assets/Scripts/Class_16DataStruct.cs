using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;


/// <summary>
/// 資料結構
/// </summary>
public class Class_16DataStruct : MonoBehaviour
{
    //陣列
    public int[] attacks = { 10, 15, 7 };
    public float[] defens = { 1.5f, 7.5f, 0.7f };

    //清單:泛型集合
    public List<int> speeds = new List<int>() { 3, 9, 7 };
    public List<string> props = new List<string>() { "藥水", "地圖" };
    public List<float> playerDefens;

    private void Awake()
    {
        //清單存取:與陣列相同
        LogSystem.LogWithColor($"第三筆速度:{speeds[2]}", "#3f3");
        speeds[0] = 10;
        LogSystem.LogWithColor($"第一筆速度:{speeds[0]}", "#3f3");
        //陣列初始化就無法增減長度
        //添加一筆道具
        props.Add("寶劍");
        //刪除第一個道具
        props.RemoveAt(0);
        //添加到頭盔編號i上
        props.Insert(1, "頭盔");

        foreach (var prop in props)
        {
            LogSystem.LogWithColor($"道具:{prop}", "#f93");
        }

        //使用建構子帶入陣列
        playerDefens = new List<float>(defens);
        //排序:小到大
        playerDefens.Sort();
        //排序:大到小
        playerDefens.Reverse();

        foreach (var item in playerDefens)
        {
            LogSystem.LogWithColor($"資料:{item}", "#f93");
        }

        // Count 指清單內的資料，根據 Add或Remove 改變
        LogSystem.LogWithColor($"數量:{props.Count}", "#77f");
        //Capcity 指清單內的容量，系統自動分配，預設為4並且以數倍成長(依照c#版本不同)
        LogSystem.LogWithColor($"數量:{props.Capacity}", "#77f");

        List<int> numbers = new List<int>();

        for (int i = 0; i < 20; i++)
        {
            numbers.Add(i);
            LogSystem.LogWithColor($"數量:{numbers.Count}", "#3f3f");
            LogSystem.LogWithColor($"數量:{numbers.Capacity}", "#f65");
        }

        //堆疊:先進後出
        Stack<string> enmemy = new Stack<string>();
        enmemy.Push("史萊姆");
        enmemy.Push("歌布林");
        LogStack<string>(enmemy);
    }
    
    private void LogStack<T>(Stack<T> stack)
    {
        foreach (var item in stack)
        {
            LogSystem.LogWithColor($"堆疊資料:{item}", "#77f");
        }
    }
}
