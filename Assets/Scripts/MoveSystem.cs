using UnityEngine;
using System.Collections;

namespace KID
{
    /// <summary>
    /// 移動系統：敵人回合讓敵人往前移動
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("移動單位"), Range(0, 10)]
        private float moveDistance = 2;

        private void Awake()
        {
            // StartMove();
        }

        /// <summary>
        /// 開始移動
        /// </summary>
        public void StartMove()
        {
            StartCoroutine(Move());                         // 啟動協同程序
        }

        /// <summary>
        /// 協同程序：移動
        /// </summary>
        private IEnumerator Move()
        {
            float count = 10;                               // 移動次數
            float z = moveDistance / count;                 // 每次移動單位

            for (int i = 0; i < count; i++)                 // 回執行移動次數
            {
                transform.position -= new Vector3(0, 0, z); // 物件往 -Z 軸移動
                yield return new WaitForSeconds(0.03f);     // 等待
            }
        }
    }
}
