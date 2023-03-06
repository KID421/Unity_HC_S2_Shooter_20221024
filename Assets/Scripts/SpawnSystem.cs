using UnityEngine;
using System.Linq;                  // 陣列 轉為 清單
using System.Collections.Generic;   // 清單

namespace KID
{
    /// <summary>
    /// 生成系統
    /// </summary>
    public class SpawnSystem : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("怪物陣列")]
        private GameObject[] prefabEnemys;
        [SerializeField, Header("第二排格子")]
        private Transform[] boxSecond;
        [Header("生成怪物的最小最大值")]
        [SerializeField, Range(1, 3)]
        private int countMin = 2;
        [SerializeField, Range(3, 10)]
        private int countMax = 5;
        #endregion

        [SerializeField, Header("打亂的格子")]
        private List<Transform> boxRandom = new List<Transform>();  // 清單 List

        #region 事件
        private void Awake()
        {
            Spawn();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 生成
        /// </summary>
        private void Spawn()
        {
            int countSpawn = Random.Range(countMin, countMax + 1);
            // print($"<color=#ff9966>生成怪物的隨機數量：{ countSpawn }</color>");

            int countToDelete = boxSecond.Length - countSpawn;
            // print($"<color=#99ff66>要刪除的格子數量：{ countToDelete }</color>");

            boxRandom = boxSecond.ToList();                             // 陣列 轉為 清單

            System.Random random = new System.Random();                 // 隨機物件

            boxRandom = boxRandom.OrderBy(x => random.Next()).ToList(); // 打亂清單

            for (int i = 0; i < countToDelete; i++)                     // 刪除 第一個 資料
            {
                boxRandom.RemoveAt(0);
            }

            SpawnEnemy();
        }

        /// <summary>
        /// 生成怪物
        /// </summary>
        private void SpawnEnemy()
        {
            // 生成 打亂格子 數量 的 隨機怪物
            for (int i = 0; i < boxRandom.Count; i++)
            {
                int random = Random.Range(0, prefabEnemys.Length);

                Instantiate(
                    prefabEnemys[random], 
                    boxRandom[i].position + new Vector3(0, 2, 0), 
                    Quaternion.identity);
            }
        }
        #endregion
    }
}
