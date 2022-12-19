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
        }

        // 方法
        // 語法：
        // 修飾詞 傳回資料類型 方法名稱 ()
        // {
        // }

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
    }
}

