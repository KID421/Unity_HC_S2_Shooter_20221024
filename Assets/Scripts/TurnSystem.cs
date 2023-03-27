﻿using TMPro;
using UnityEngine;

namespace KID
{
    /// <summary>
    /// 回合系統
    /// </summary>
    public class TurnSystem : MonoBehaviour
    {
        [SerializeField, Header("文字層數數字")]
        private TextMeshProUGUI textFloor;

        private int countFloor = 1;
        private string nameMarble = "彈珠";
        private int countMarbleRecycle;
        private ControlSystem controlSystem;
        private SpawnSystem spawnSystem;

        private void Awake()
        {
            // FOOT 透過類型尋找物件
            // 條件：該類型在場景上只能有一個
            controlSystem = FindObjectOfType<ControlSystem>();
            spawnSystem = FindObjectOfType<SpawnSystem>();
            // 更新層數文字
            textFloor.text = countFloor.ToString();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameMarble))
            {
                countMarbleRecycle++;
                Destroy(other.gameObject);

                // print($"<color=#66ff99>回收彈珠數量：{ countMarbleRecycle }</color>");

                if (countMarbleRecycle == controlSystem.countMarbleShoot)
                {
                    // print("<color=#ff6666>敵人回合</color>");

                    EnemyTurn();
                }
            }
        }

        /// <summary>
        /// 敵人回合
        /// </summary>
        private void EnemyTurn()
        {
            // 所有敵人開始移動
            MoveSystem[] moves = FindObjectsOfType<MoveSystem>();

            for (int i = 0; i < moves.Length; i++)
            {
                moves[i].StartMove();
            }

            // 生成下一波敵人
            // 延遲呼叫(方法名稱，延遲時間)；
            Invoke("SpawnNextEnemy", 0.8f);
        }

        /// <summary>
        /// 生成下一波敵人並換玩家回合
        /// </summary>
        private void SpawnNextEnemy()
        {
            spawnSystem.Spawn();

            PlayerTurn();
        }

        /// <summary>
        /// 玩家回合
        /// </summary>
        private void PlayerTurn()
        {
            controlSystem.canShoot = true;
            countMarbleRecycle = 0;
            countFloor++;
            textFloor.text = countFloor.ToString();
        }
    }
}
