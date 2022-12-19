using UnityEngine;

namespace KID
{
    /// <summary>
    /// 控制系統
    /// </summary>
    public class ControlSystem : MonoBehaviour
    {
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
    }
}

