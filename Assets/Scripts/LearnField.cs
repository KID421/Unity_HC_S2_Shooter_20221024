using UnityEngine;

/// <summary>
/// 這是摘要區域，添加程式的簡短說明
/// 學習欄位 Field 的腳本
/// </summary>
public class LearnField : MonoBehaviour
{
    #region 欄位基礎語法與四大類型
    // 欄位 Field
    // 作用：儲存遊戲內的資料，例如：血量或等級...

    // 語法：
    // 欄位名稱習慣使用小寫開頭
    // 資料類型 欄位名稱；
    int level;

    // C# 常用四大類型
    // 整　數：正負沒有小數點的數值 1、999、-123
    int enemyCount;
    // 浮點數：正負有小數點的數值 1.23、-9.99
    float speed;
    // 字　串：文字訊息 皮卡丘、小刀、@#
    string namePlayer;
    // 布林值：儲存兩個值，是或否 true、false
    bool isDead;
    #endregion

    #region 欄位完整語法與範例
    // 語法：
    // 修飾詞 資料類型 欄位名稱 指定 預設值；
    // = 指定符號：將右邊的值運算完指定給左邊
    // 修飾詞：
    // 私人：該資料僅在此類別內允許存取 private (預設為私人，沒有寫就是私人)
    // 不顯示在屬性面板
    // 公開：該資料在所有類別內允許存取 public
    // 顯示在屬性面板

    public int skillCount = 3;
    public float speedTurn = 9.5f;
    public float speedWalk = 3.7F;
    public string namePet = "@皮卡丘@";
    public bool isGrounded = true;
    public bool isPass = false;
    #endregion

    // 欄位屬性
    // 作用：輔助欄位
    // [屬性名稱(值)] - 欄位的上方

    // 標題
    [Header("武器名稱")]
    public string nameWeapon = "美工刀";
    // 提示
    [Tooltip("指玩家的等級。")]
    public int lv = 70;
    // 範圍(最小，最大) - 僅限浮點數與整數 (數值) 使用
    [Range(10, 500)]
    public float attack = 3.5f;
    [Range(1, 50)]
    public int defense = 10;
    [Range(7, 100)]
    public bool hasWeapon;

    // 序列化：將私人資料顯示在屬性面板
    [SerializeField]
    private float hp = 500;

    [Header("數量")]
    [Range(0, 10)]
    public int count;
    [Header("是否擁有道具"), Tooltip("是否擁有任務指定的重要道具。")]
    public bool hasProp;

    private void Awake()
    {
        // 欄位資料的存取 Set、Get
        // 1. Get 取得欄位資料
        // 語法：欄位名稱
        // 欄位資料以屬性面板為主
        print("技能數量：" + skillCount);
        print("旋轉速度：" + speedTurn);
        // 2. Set 設定欄位資料
        // 語法：欄位名稱 指定 值；
        speedWalk = 7.2f;
        // namePet = 123;       // 錯誤的資料類型
        isPass = true;
    }
}
