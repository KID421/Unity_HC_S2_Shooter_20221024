using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習 API：靜態 Static
    /// 已經儲存在電腦記憶體裡面的資料
    /// </summary>
    public class LearnAPIStatic : MonoBehaviour
    {
        private void Awake()
        {
            // 靜態屬性 Static Properties
            // 1. 取得
            // 語法：
            // 類別.靜態屬性名稱
            print("隨機值：" + Random.value);
            print("當前指標能見度：" + Cursor.visible);

            // 2. 設定
            // 語法：
            // 類別.靜態屬性名稱 指定 值；
            Cursor.visible = false;         // 隱藏滑鼠
            Screen.fullScreen = true;       // 設定為全螢幕

            // 唯讀屬性不能設定 (Read Only)
            // Random.value = 1.234f;

            // 靜態方法 Static Method
            // 語法：
            // 類別.靜態方法名稱(對應的引數)；
            print(Mathf.Abs(-321.5f));      // 數學.絕對值(數值)

            // Random.RandomRange(100f, 200f);   // 已過時的 API 建議不要用

            float random = Random.Range(100f, 200f);
            print($"<color=yellow>隨機值介於 100 與 200：{random}</color>");
        }

        private void Start()
        {
            
        }

        private void Update()
        {
            
        }
    }
}

