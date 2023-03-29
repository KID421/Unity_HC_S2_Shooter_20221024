using UnityEngine;

namespace KID
{
    /// <summary>
    /// 場景控制
    /// </summary>
    public class SceneContrl : MonoBehaviour
    {
        // Button 跟程式溝通的條件
        // 1. 定義公開的方法
        // 2. OnClick 選取該公開的方法

        public void Replay()
        {
            print("重新遊戲");
        }

        public void Quit()
        {
            print("離開遊戲");
        }
    }
}
