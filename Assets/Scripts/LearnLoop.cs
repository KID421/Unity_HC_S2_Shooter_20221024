using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習迴圈 while 與 for
    /// </summary>
    public class LearnLoop : MonoBehaviour
    {
        private void Awake()
        {
            // while 語法：
            // while (布林值) { 程式，當布林值為 true 才會持續執行 }

            int number = 0;

            while (number < 5)
            {
                print($"<color=#119933>while 迴圈： { number } </color>");
                number++;
            }
        }
    }
}
