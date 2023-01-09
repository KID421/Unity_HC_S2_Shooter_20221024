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

            // 2. 設定
        }
    }
}

