using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習判斷式(條件式)
    /// if、switch
    /// </summary>
    public class LearnCondition : MonoBehaviour
    {
        public bool openDoor = true;

        private void Awake()
        {
            // 判斷式 if (如果)
            // if 語法：
            // if (布林值) { 程式，當布林值為 true 才會執行 }
            
            if (true)
            {
                print("我是判斷式 if，true 才看的到這段訊息。");
            }

            // false 會出現綠色蚯蚓，並且大括號內程式不會執行
            if (false)
            {
                print("我是判斷式 if，false 看不到這段訊息。");
            }

            // else (否則) 必須放在 if 下方
            // else 語法：
            // if (布林值) { 程式，當布林值為 true 才會執行 }
            // else { 程式，當布林值為 false 才會執行 }

            if (openDoor)
            {
                print("<color=#3333ff>開門！</color>");
            }
            else
            {
                print("<color=#ff3333>關門！</color>");
            }
        }

        // 分數：低於 60 分，不及格 D
        // 分數：低於 70 分，C--
        // 分數：低於 80 分，很棒 C
        // 分數：低於 90 分，很讚 B

        public int score = 30;

        [Header("血量"), Range(0, 100)]
        public int hp = 100;

        public string prop;

        public enum Season
        {
            Spring, Summer, Fall, Winter
        }

        public Season season;

        private void Update()
        {
            #region 判斷式 if 練習
            // 語法：
            // if (布林值) { 程式，當布林值為 true 才會執行 }
            // else if (布林值) { 程式，當布林值為 true 才會執行 }
            // else if (布林值) { 程式，當布林值為 true 才會執行 }
            // else if (布林值) { 程式，當布林值為 true 才會執行 }
            // else { 程式，當布林值為 false 才會執行 }

            // else if 必須放在 if 下方，else 上方，沒有數量限制

            if (score < 60)
            {
                print("不及格，D");
            }
            else if (score < 70)
            {
                print("C--");
            }
            else if (score < 80)
            {
                print("很棒，C");
            }
            else
            {
                print("很讚， B");
            }
            #endregion

            #region 判斷式 if、else if、else
            if (hp >= 80)
            {
                print("<color=#33ff33>安全</color>");
            }
            else if (hp >= 60)
            {
                print("<color=#33ff33>注意</color>");
            }
            else if (hp >= 40)
            {
                print("<color=#33ff33>警告</color>");
            }
            else if (hp >= 0)
            {
                print("<color=#33ff33>危險</color>");
            }
            #endregion

            #region 判斷式 switch 練習
            // 判斷式 switch
            // 語法：
            // switch (判斷的值)
            // {
            //      case 區塊值：
            //          當 判斷的值 等於 區塊值 執行此處程式；
            //          break；
            // 
            //      (可省略)
            //      default:
            //          當 判斷的值 不等於 上方所有 區塊值 執行此處程式；
            //          break;
            // }

            // 紅水、藍水
            switch (prop)
            {
                case "紅水":
                    print("補血 100");
                    break;

                case "藍水":
                    print("補魔 100");
                    break;

                default:
                    print("這個道具不能使用！");
                    break;
            }
            #endregion

            switch (season)
            {
                case Season.Spring:
                    print("春天");
                    break;
                case Season.Summer:
                    print("夏天");
                    break;
                case Season.Fall:
                    print("秋天");
                    break;
                case Season.Winter:
                    print("冬天");
                    break;
                default:
                    print("這不是季節");
                    break;
            }
        }
    }
}

