using UnityEngine;
using System.Collections;

namespace KID
{
    /// <summary>
    /// 學習協同程序
    /// </summary>
    public class LearnCoroutine : MonoBehaviour
    {
        // 使用協同程序
        // 作用：讓程式的時間停止
        // 條件：
        // 1. 引用系統集合命名空間
        // 2. 定義一個傳回 IEnumerator 的方法
        // 3. 在方法內使用 yield return 時間，時間停止
        // 4. 使用 Start Coroutine 啟動

        private void Awake()
        {
            StartCoroutine(Test()); // 開始協同程序(協同程序名稱())
        }

        private IEnumerator Test()
        {
            print("<color=#ff6666>第一行</color>");

            yield return new WaitForSeconds(1);

            print("<color=#ff6666>第二行</color>");

            yield return new WaitForSeconds(2);

            print("<color=#ff6666>第三行</color>");
        }
    }
}
