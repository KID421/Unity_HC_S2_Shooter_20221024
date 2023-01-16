using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習非靜態 API
    /// 與靜態的差異在於非靜態需要實體物件
    /// 實體物件：場景上的物件
    /// </summary>
    public class LearnAPI : MonoBehaviour
    {
        // 屬性
        // 1. 取得

        // 語法：
        // 類別名稱 欄位名稱； - 欄位，儲存實體物件用
        // 欄位名稱.屬性名稱；

        public Transform cube;
        public BoxCollider cubeBox;

        // 2. 設定
        // 類別名稱 欄位名稱； - 欄位，儲存實體物件用
        // 欄位名稱.屬性名稱 指定 值；

        // 方法
        // 3. 使用方法
        // 類別名稱 欄位名稱； - 欄位，儲存實體物件用
        // 欄位名稱.方法名稱(對應的引數)；

        public Transform kid;

        private void Awake()
        {
            // Random.value             // 靜態的語法
            // Transform.position       // 錯誤的用法

            print($"立方體的座標：{cube.position}");
            print($"立方體的方形碰撞尺寸：{cubeBox.size}");

            cube.eulerAngles = new Vector3(0, 45, 0);
            cubeBox.center = new Vector3(0, 3, 0);
        }

        private void Update()
        {
            kid.Rotate(30, 0, 0);
        }
    }
}
