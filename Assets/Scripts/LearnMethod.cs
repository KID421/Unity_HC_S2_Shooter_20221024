using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習方法、功能、函式
    /// Method、Function
    /// </summary>
    public class LearnMethod : MonoBehaviour
    {
        // 方法必須在事件內呼叫才會執行
        private void Awake()
        {
            // 方法名稱()；
            Test();
            Test();

            ShootFire();
            ShootThund();
            ShootIce();

            Shoot("毒");             // 呼叫時放在小括號的稱為引數
            Shoot("光");             // 有預設值的參數可以不用填，選填式參數
            Shoot("水", "噗噗噗");

            // 火，咻咻咻，灰燼
            // Shoot("火", "灰燼"); // 錯誤，灰燼跑錯地方
            Shoot("火", effect: "灰燼");
        }

        // 方法
        // 語法：
        // 參數沒有數量限制，但建議不要太多
        // 修飾詞 傳回資料類型 方法名稱 (參數類型 參數名稱，參數類型 參數名稱，...)
        // {
        // }

        #region 方法練習
        // void 無
        private void Test()
        {
            print("我是測試方法");
        }

        // 技能系統：
        // 發射火球、發射電球、發射冰球
        // 加音效
        private void ShootFire()
        {
            print("球的屬性：火");
            print("播放音效：咻咻咻");
        }
        private void ShootThund()
        {
            print("球的屬性：電");
            print("播放音效：滋滋滋");
        }
        private void ShootIce()
        {
            print("球的屬性：冰");
            print("播放音效：無");
        }
        #endregion

        // 參數可以添加預設值，呼叫時可不用填
        private void Shoot(string type, string sound = "咻咻咻", string effect = "光點")
        {
            print("<color=yellow>球的屬性：" + type + "</color>");
            print("<color=yellow>播放音效：" + sound + "</color>");
            print($"<color=#3366ff>播放特效： {effect} </color>");
        }

        /* 多行註解
         * 錯誤範例：選填式參數要寫在右邊
        private void WrongSample(string a = "哈囉", string b)
        {

        }
        */
    }
}
