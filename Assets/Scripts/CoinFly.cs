using UnityEngine;

namespace KID
{
    /// <summary>
    /// 金幣飛往上方
    /// </summary>
    public class CoinFly : MonoBehaviour
    {
        [SerializeField, Header("延遲幾秒後飛行"), Range(0, 5)]
        private float delayFly = 1.5f;
        [SerializeField, Header("飛行速度"), Range(0, 100)]
        private float speedFly = 10.5f;

        private Transform pointCoinTo;

        private CoinSystem coinSystem;

        private void Awake()
        {
            coinSystem = FindObjectOfType<CoinSystem>();

            pointCoinTo = GameObject.Find("金幣前往的位置").transform;

            // 延遲呼叫("方法名稱"，延遲秒數)
            Invoke("StartFly", delayFly);
        }

        private void Update()
        {
            Fly();
        }

        private void StartFly()
        {
            // 啟動這個腳本
            enabled = true;
        }

        /// <summary>
        /// 飛行
        /// </summary>
        private void Fly()
        {
            // A 物件 往 B 物件移動並添加 幀 ㄓㄥˋ 數 解決速度差問題
            Vector3 point = Vector3.MoveTowards(transform.position, pointCoinTo.position, speedFly * Time.deltaTime);

            // print("座標：" + point);

            // 更新金幣座標
            transform.position = point;

            // 判斷金幣距離前往的位置小於 3 就刪除
            float distance = Vector3.Distance(transform.position, pointCoinTo.position);

            if (distance <= 3)
            {
                coinSystem.UpdateCoin();
                Destroy(gameObject);
            }
        }
    }
}
