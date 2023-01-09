using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習迴圈 while 與 for
    /// </summary>
    public class LearnLoop : MonoBehaviour
    {
        public string[] players = { "小智", "小剛", "小霞", "小光", "皮卡丘" };

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

            // for (初始值；布林值；迴圈結束會執行的程式) { 程式，當布林值為 true 才會持續執行 }
            for (int i = 0; i < 5; i++)
            {
                print($"<color=#ff3333>for 迴圈： { i } </color>");
            }

            for (int i = 0; i < players.Length; i++)
            {
                print($"<color=#3333ff>玩家名稱： { players[i] } </color>");
            }
        }
    }
}
