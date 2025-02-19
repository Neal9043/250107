using Unity.VisualScripting;
using UnityEngine;

using UnityEngine;

public class Class10_2_Polymorphism : MonoBehaviour
{
    /// <summary>
    /// 多型
    /// </summary>
    private void Awake()
    {
        Trap trap1 = new Trap("落穴", 3);
        Magic magic1 = new Magic("死者甦醒", 5);

        // 多型：可以使用父類別或是自己的成員
        trap1.Information();         // 呼叫 Trap 繼承自 Card 的 Information()
        trap1.Information(37);       // 呼叫 Trap 獨有的 Information(int index)

        // 多型（比較常用）：宣告時使用父類別，實例化的類別決定型式
        Card card1 = new Card("一般卡片", 0);
        Card magic2 = new Magic("去去武器走", 7);
        card1.Information();  // 呼叫 Card 方法
        magic2.Information(); // 呼叫 Magic 的覆寫方法
    }
}

public class Card
{
    public string name;
    public int cost;

    public Card(string _name, int _cost)
    {
        name = _name;
        cost = _cost;
    }

    // 讓子類別可以覆寫
    public virtual void Information()
    {
        Debug.Log($"<color=#aaa>{name} 這是一張卡</color>");
    }
}

public class Trap : Card
{
    public Trap(string _name, int _cost) : base(_name, _cost)
    {
    }

    // Trap 額外增加的方法，無法在 Card 型別變數下使用
    public void Information(int index)
    {
        Debug.Log($"<color=#f77>{name} 這是一張陷阱卡 編號: {index}</color>");
    }

    // 讓 Trap 也能在父類別型態下表現多型
    public override void Information()
    {
        Debug.Log($"<color=#f77>{name} 這是一張陷阱卡</color>");
    }
}

public class Magic : Card
{
    public Magic(string _name, int _cost) : base(_name, _cost)
    {
    }

    // 正確覆寫 Card.Information()
    public override void Information()
    {
        Debug.Log($"<color=#77f>{name} 這是一張魔法卡</color>");
    }
}
