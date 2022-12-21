using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習陣列 Array
    /// </summary>
    public class LearnArray : MonoBehaviour
    {
        public int expLv1 = 100;
        public int expLv2 = 10000;
        public int expLv3 = 1000000;

        // 陣列：儲存多筆相同類型的資料
        // 語法：
        // 修飾詞 資料類型[] 欄位名稱 指定 預設值；
        public int[] expLv;

        // 給陣列資料
        public string[] weapons = new string[3];

        // 任務資料
        // 1 過關
        // 2 過關
        // 3 未過關
        public bool[] missions = { true, true, false };

        public string[] pets = { "皮卡丘", "小智", "比雕" };

        private void Awake()
        {
            // 存取陣列資料
            // 取得 Get
            // 陣列名稱[編號]
            print(pets[2]);

            // 存放 Set
            // 陣列名稱[編號] 指定 值；
            pets[1] = "卡比瘦";

            // 取得陣列數量
            // 陣列.長度
            print("寵物數量：" + pets.Length);
        }
    }
}

