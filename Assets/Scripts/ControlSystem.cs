using UnityEngine;
using System.Collections;

namespace KID
{
    /// <summary>
    /// 控制系統
    /// </summary>
    public class ControlSystem : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("旋轉速度"), Range(0, 100)]
        private float speedTurn = 10.5f;
        [SerializeField, Header("可發射彈珠數量"), Range(0, 100)]
        private int countMarbleShoot = 10;
        [SerializeField, Header("彈珠速度"), Range(0, 5000)]
        private int speedMarble = 1500;
        [SerializeField, Header("彈珠發射間隔"), Range(0, 3)]
        private float fireInterval = 0.5f;
        [SerializeField, Header("彈珠預製物")]
        private GameObject prefabMarble;

        private string parAttack = "觸發攻擊";
        #endregion

        [SerializeField, Header("生成彈珠的位置")]
        private Transform pointSpawnMarble;

        #region 事件
        private void Awake()
        {
            StartCoroutine(ShootMarble());
        }

        private void Update()
        {
            
        }
        #endregion

        #region 方法
        /// <summary>
        /// 發射彈珠
        /// </summary>
        private IEnumerator ShootMarble()
        {
            for (int i = 0; i < countMarbleShoot; i++)
            {
                // 暫存彈珠 = 生成物件(要生成的物件，座標，角度)
                // Quaternion.identity 零度角
                GameObject tempMarble = Instantiate(prefabMarble, pointSpawnMarble.position, Quaternion.identity);

                // 暫存彈珠.取得元件<剛體>().添加推力(X, Y, Z);
                tempMarble.GetComponent<Rigidbody>().AddForce(0, 0, speedMarble);
                
                yield return new WaitForSeconds(fireInterval);
            }
        }
        #endregion
    }
}

