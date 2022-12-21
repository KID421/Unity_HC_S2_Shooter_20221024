using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習列舉 Enumerator
    /// </summary>
    public class LearnEnum : MonoBehaviour
    {
        // 1. 定義列舉的內容
        // 2. 定義欄位儲存列舉

        // 列舉語法：
        // 修飾詞 列舉 列舉名稱
        // {
        //      選項 1，選項 2，選項 3
        // }

        public enum Season
        {
            Spring, Summer, Fall, Winter
        }

        public Season season;

        public Season season1 = Season.Summer;
    }
}
