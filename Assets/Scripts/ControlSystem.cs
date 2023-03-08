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
        [Header("可發射彈珠數量"), Range(0, 100)]
        public int countMarbleShoot = 10;
        [SerializeField, Header("彈珠速度"), Range(0, 5000)]
        private int speedMarble = 1500;
        [SerializeField, Header("彈珠發射間隔"), Range(0, 3)]
        private float fireInterval = 0.5f;
        [SerializeField, Header("彈珠預製物")]
        private GameObject prefabMarble;
        [SerializeField, Header("生成彈珠的位置")]
        private Transform pointSpawnMarble;
        [SerializeField, Header("箭頭物件")]
        private GameObject goArrow;
        [SerializeField, Header("玩家滑鼠位置")]
        private Transform pointPlayerMouse;

        private string parAttack = "觸發攻擊";
        #endregion

        /// <summary>
        /// 玩家可不可以射擊
        /// </summary>
        public bool canShoot = true;

        #region 事件
        private void Awake()
        {
            // StartCoroutine(ShootMarble());
        }

        private void Update()
        {
            InputManager();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 輸入管理：偵測玩家按鍵
        /// </summary>
        private void InputManager()
        {
            // 如果 不能射擊 就跳出 不執行下方程式
            if (!canShoot) return;

            if (Input.GetKeyDown(KeyCode.Mouse0))       // 如果 按下左鍵
            {
                // print("<color=green>按下左鍵</color>");

                goArrow.SetActive(true);                // 顯示 箭頭
            }
            else if (Input.GetKey(KeyCode.Mouse0))      // 如果 按住左鍵
            {
                // print("<color=yellow>按住左鍵</color>");

                SetMousePosition();                     // 呼叫 設定滑鼠座標方法
            }
            else if (Input.GetKeyUp(KeyCode.Mouse0))    // 如果 放開左鍵
            {
                // print("<color=red>放開左鍵</color>");

                goArrow.SetActive(false);               // 隱藏 箭頭

                StartCoroutine(ShootMarble());

                // 不能射擊
                canShoot = false;
            }
        }

        /// <summary>
        /// 設定滑鼠座標
        /// </summary>
        private void SetMousePosition()
        {
            Vector3 posMouse = Input.mousePosition;                         // 滑鼠座標

            posMouse.z = 10;                                                // 滑鼠座標深度，與攝影機 Y 一樣

            // print($"<color=#ff9966>滑鼠座標：{posMouse}</color>");

            Vector3 posWorld = Camera.main.ScreenToWorldPoint(posMouse);    // 滑鼠座標轉為世界座標

            // print($"<color=#99ff66>轉換後的世界座標：{posWorld}</color>");

            pointPlayerMouse.position = posWorld;                           // 球體座標 = 新的座標

            transform.LookAt(posWorld);                 // 此物件的座標面向(球體)

            Vector3 angle = transform.eulerAngles;      // 取得角色座標
            angle.x = 0;                                // X 歸零
            angle.z = 0;                                // Z 歸零
            transform.eulerAngles = angle;              // 角色座標 = 新的座標
        }

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

                // 暫存彈珠.取得元件<剛體>().添加推力(X, Y, Z);   // 世界座標
                // tempMarble.GetComponent<Rigidbody>().AddForce(0, 0, speedMarble);

                // X - trasform.right   紅色軸向
                // Y - trasform.up      綠色軸向
                // Z - trasform.forward 藍色軸向

                tempMarble.GetComponent<Rigidbody>().AddForce(transform.forward * speedMarble);

                yield return new WaitForSeconds(fireInterval);
            }
        }
        #endregion
    }
}
