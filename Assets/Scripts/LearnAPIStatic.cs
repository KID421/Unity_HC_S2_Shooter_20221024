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
            // 3. 使用方法
            // 語法：
            // 類別.靜態方法名稱(對應的引數)；
            print(Mathf.Abs(-321.5f));      // 數學.絕對值(數值)

            // Random.RandomRange(100f, 200f);   // 已過時的 API 建議不要用

            float random = Random.Range(100f, 200f);
            print($"<color=yellow>隨機值介於 100 與 200：{random}</color>");
        }

        private void Start()
        {
            print($"<color=#6666ff>攝影機總數：{ Camera.allCamerasCount }</color>");
            print($"<color=#6666ff>圓周率：{ Mathf.PI }</color>");

            Physics.gravity = new Vector3(0, 10, 0);
            print($"<color=#ff6666>地心引力：{ Physics.gravity }</color>");

            Time.timeScale = 5;
            print($"<color=#ff6666>時間尺寸：{ Time.timeScale }</color>");

            Screen.brightness = 0.3f;
            print($"<color=#ff6666>螢幕亮度：{ Screen.brightness }</color>");
            // 輸出還會是 1 是正確的～

            print($"<color=#66ff66>9.99 去小數點：{ Mathf.Floor(9.99f) }</color>");

            Application.OpenURL("https://unity.com/");
        }

        private void Update()
        {
            // print($"<color=#6666ff>經過時間：{ Time.time }</color>");

            bool space = Input.GetKey(KeyCode.Space);
            print($"<color=#66ff66>玩家是否按下空白鍵：{ space }</color>");
        }
    }
}
